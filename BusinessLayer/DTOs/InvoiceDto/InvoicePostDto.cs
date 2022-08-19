using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DTOs.InvoiceDto
{
    public class InvoicePostDto
    {
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }
        public int OrderNr { get; set; }
        public int LoanId { get; set; }
    }
}
