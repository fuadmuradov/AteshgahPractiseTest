using PractisalTest.Core.Entities;
using PractisalTest.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PractisalTest.Data.Repositories
{
    public class LoanRepository:Repository<Loan>, ILoanRepository
    {
        public LoanRepository(PractiseDbContext context):base(context)
        {

        }
    }
}
