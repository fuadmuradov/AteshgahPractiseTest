using PractisalTest.Core;
using PractisalTest.Core.IRepositories;
using PractisalTest.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PractisalTest.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PractiseDbContext context;

        ICLientRepository cLientRepository;
        ILoanRepository loanRepository;
        IInvoiceRepository invoiceRepository;

        public UnitOfWork(PractiseDbContext context)
        {
            this.context = context;
        }
        public ICLientRepository ClientRepository => cLientRepository ?? new ClientRepository(context);

        public ILoanRepository LoanRepository => loanRepository ?? new LoanRepository(context);

        public IInvoiceRepository InvoiceRepository => invoiceRepository ?? new InvoiceRepository(context);
    }
}
