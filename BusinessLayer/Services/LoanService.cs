using AutoMapper;
using BusinessLayer.DTOs.InvoiceDto;
using BusinessLayer.DTOs.LoanDto;
using BusinessLayer.Interfaces;
using PractisalTest.Core;
using PractisalTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class LoanService : ILoanService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public LoanService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task AddLoanAsync(LoanInvoiceVM loanInvoice)
        {
            InvoiceCalculatePostDto postDto = new InvoiceCalculatePostDto();
            postDto.amount = loanInvoice.Amount;
            postDto.period = loanInvoice.Period;
            postDto.date = loanInvoice.PayoutDate;
            postDto.rate = loanInvoice.InterestRate;

            Loan loanPost = new Loan();
            loanPost.Amount = loanInvoice.Amount;
            loanPost.ClientId = loanInvoice.ClientId;
            loanPost.InterestRate = loanInvoice.InterestRate;
            loanPost.PayoutDate = loanInvoice.PayoutDate;

            await unitOfWork.LoanRepository.AddAsync(loanPost);
           

            List<InvoiceCalculateGetDto> invoiceCalculateGets = await Calculate(postDto);
            int orderNum = 1;
            foreach (var item in invoiceCalculateGets)
            {
                Invoice invoice = new Invoice();
                invoice.Amount = item.amount;
                invoice.DueDate = item.date;
                invoice.OrderNr = orderNum;
                invoice.Loan = loanPost;
                await unitOfWork.InvoiceRepository.AddAsync(invoice);
            }

            await unitOfWork.LoanRepository.SaveDbAsync();
        }

        public async Task<List<InvoiceCalculateGetDto>> Calculate(InvoiceCalculatePostDto postDto)
        {
            List<InvoiceCalculateGetDto> calcualategetDtos = new List<InvoiceCalculateGetDto>();

            double monthly = postDto.amount / postDto.period;
            for (int i = 1; i < postDto.period+1; i++)
            {
                InvoiceCalculateGetDto invoice = new InvoiceCalculateGetDto();
               
                double tax = postDto.amount * postDto.rate / 100;
                double result = monthly + tax;
                invoice.amount = Math.Round(result, 2);
                invoice.date = postDto.date.AddMonths(i);
                invoice.serviceNr = i.ToString().PadLeft(4, '0');
                postDto.amount = postDto.amount - monthly;

                calcualategetDtos.Add(invoice);
            }

            return calcualategetDtos;
        }

        public async Task<List<LoanGetDto>> GetAllLoans()
        {
            List<Loan> Loans = unitOfWork.LoanRepository.GetAll(x => x.Id >0, "Client").ToList();
            List<LoanGetDto> loanGets = mapper.Map<List<Loan>, List<LoanGetDto>>(Loans);

            return loanGets;
        }
    }
}
