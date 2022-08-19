using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DTOs.InvoiceDto
{
    public class InvoiceCalculateGetDto
    {
        public DateTime date { get; set; }
        public double amount { get; set; }
        public string serviceNr { get; set; }
    }
}
