using AutoMapper;
using BusinessLayer.DTOs.ClientDto;
using BusinessLayer.DTOs.InvoiceDto;
using BusinessLayer.DTOs.LoanDto;
using PractisalTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Profiles
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Client, ClientGetDto>();
            CreateMap<ClientPostDto, Client>();
            CreateMap<Loan, LoanGetDto>();
            CreateMap<LoanPostDto, Loan>();
            CreateMap<Invoice, InvoiceGetDto>();
            CreateMap<InvoicePostDto, Invoice>();
        }
    }
}
