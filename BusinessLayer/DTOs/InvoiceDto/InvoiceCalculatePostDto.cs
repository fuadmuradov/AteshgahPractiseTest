using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DTOs.InvoiceDto
{
    public class InvoiceCalculatePostDto
    {
        public double amount { get; set; }
        public int rate { get; set; }
        public int period { get; set; }
        public DateTime date { get; set; }
    }
}
