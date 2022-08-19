using PractisalTest.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PractisalTest.Core
{
    public interface IUnitOfWork
    {
        ICLientRepository ClientRepository { get; }

        ILoanRepository LoanRepository { get; }

        IInvoiceRepository InvoiceRepository { get; }
    }
}
