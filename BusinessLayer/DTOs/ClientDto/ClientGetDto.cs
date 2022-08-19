using BusinessLayer.DTOs.ClientDto;
using BusinessLayer.DTOs.LoanDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DTOs.ClientDto
{
    public class ClientGetDto
    {
        public string ClientUniqueId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNr { get; set; }
        public IList<LoanGetDto> Loans { get; set; }
    }
}
