using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DTOs.LoanDto
{
    public class LoanInvoiceVM
    {
        public double Amount { get; set; }
        public int InterestRate { get; set; }
        public DateTime PayoutDate { get; set; }
        public string ClientId { get; set; }
        public int Period { get; set; }
    }
}
