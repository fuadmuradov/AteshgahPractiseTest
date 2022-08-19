using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PractisalTest.Core.Entities
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceNr { get; set; }
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }
        public int OrderNr { get; set; }
        public int LoanId { get; set; }
        public Loan Loan { get; set; }

    }
}
