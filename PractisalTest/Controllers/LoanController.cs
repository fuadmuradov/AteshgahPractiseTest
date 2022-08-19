using BusinessLayer.DTOs.ClientDto;
using BusinessLayer.DTOs.InvoiceDto;
using BusinessLayer.DTOs.LoanDto;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PractisalTest.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractisalTest.Controllers
{
    public class LoanController : Controller
    {
        private readonly ILoanService loanService;
        private readonly IClientService clientService;
        public LoanController(ILoanService loanService, IClientService clientService)
        {
            this.loanService = loanService;
            this.clientService = clientService;
        }
        public async Task<IActionResult> Index()
        {
            List<LoanGetDto> loans = await loanService.GetAllLoans();
              
            return View(loans);
        }

        public async Task<IActionResult> AddLoan()
        {
            List<ClientGetDto> clients = await clientService.GetAllClient();
            List<ClientVM> clients2 = new List<ClientVM>();
            foreach (var item in clients)
            {
                ClientVM clientVM = new ClientVM();
                clientVM.Id = item.ClientUniqueId;
                clientVM.Name = item.ClientUniqueId + " | " + item.Name + " " + item.Surname;
                clients2.Add(clientVM);
            }
            ViewBag.Clients = clients2;
            return View();
        }

        [HttpPost]
        public IActionResult AddLoan(LoanInvoiceVM postDto)
        {
            loanService.AddLoanAsync(postDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> GetInvoiceList(string amount, string period, string rate, string date)
        {

            InvoiceCalculatePostDto postDto = new InvoiceCalculatePostDto();
            if(Convert.ToDouble(amount)<100 || Convert.ToDouble(amount)>5000)
                return PartialView("InvoiceListPartialView", new List<InvoiceCalculateGetDto>());
            postDto.amount = Convert.ToDouble(amount);
            postDto.period = Convert.ToInt32(period);
            postDto.rate = Convert.ToInt32(rate);
            postDto.date = Convert.ToDateTime(date);
            List < InvoiceCalculateGetDto > invoices = await loanService.Calculate(postDto);
            return PartialView("InvoiceListPartialView", invoices);
        }
    }
}
