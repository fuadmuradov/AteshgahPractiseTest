using PractisalTest.Core.Entities;
using PractisalTest.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PractisalTest.Data.Repositories
{
    public class ClientRepository:Repository<Client>, ICLientRepository
    {
        public ClientRepository(PractiseDbContext context):base(context)
        {

        }
    }
}
