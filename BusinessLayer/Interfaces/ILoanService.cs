using BusinessLayer.DTOs.InvoiceDto;
using BusinessLayer.DTOs.LoanDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface ILoanService
    {
        Task<List<InvoiceCalculateGetDto>> Calculate(InvoiceCalculatePostDto postDto);
        Task<List<LoanGetDto>> GetAllLoans();
        Task AddLoanAsync(LoanInvoiceVM loanInvoice);
    }
}
