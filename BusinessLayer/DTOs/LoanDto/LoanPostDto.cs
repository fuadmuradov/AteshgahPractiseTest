using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DTOs.LoanDto
{
    public class LoanPostDto
    {
        public double Amount { get; set; }
        public int InterestRate { get; set; }
        public DateTime PayoutDate { get; set; }
        public string ClientId { get; set; }

    }
}
