using System;
using System.Collections.Generic;
using System.Text;

namespace PractisalTest.Core.Entities
{
    public class Loan
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public int InterestRate { get; set; }
        public DateTime PayoutDate { get; set; }
        public string ClientId { get; set; }
        public Client Client { get; set; }
        public IList<Invoice> Invoices { get; set; }
    }
}
