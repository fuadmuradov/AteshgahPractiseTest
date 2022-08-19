using BusinessLayer.DTOs.ClientDto;
using BusinessLayer.DTOs.LoanDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DTOs.InvoiceDto
{
    public class InvoiceGetDto
    {
        public int InvoiceNr { get; set; }
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }
        public int OrderNr { get; set; }
        public int LoanId { get; set; }
        public LoanGetDto Loan { get; set; }

    }
}
