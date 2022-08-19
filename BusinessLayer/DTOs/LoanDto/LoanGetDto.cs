using BusinessLayer.DTOs.ClientDto;
using BusinessLayer.DTOs.InvoiceDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DTOs.LoanDto
{
    public class LoanGetDto
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public int InterestRate { get; set; }
        public DateTime PayoutDate { get; set; }
        public string ClientId { get; set; }
        public ClientGetDto Client { get; set; }
        public IList<InvoiceGetDto> Invoices { get; set; }
    }
}
