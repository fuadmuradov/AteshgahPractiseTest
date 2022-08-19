using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PractisalTest.Core.Entities
{
    public class Client
    {
        [Key]
        public string ClientUniqueId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNr { get; set; }
        public IList<Loan> Loans { get; set; }
    }
}
