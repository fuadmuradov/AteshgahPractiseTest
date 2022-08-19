using PractisalTest.Core.Entities;
using PractisalTest.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PractisalTest.Data.Repositories
{
    public class InvoiceRepository:Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(PractiseDbContext context):base(context)
        {

        }
    }
}
