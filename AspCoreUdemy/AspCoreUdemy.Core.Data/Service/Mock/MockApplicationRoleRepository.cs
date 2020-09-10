using AspCoreUdemy.Core.Data.Infrastructure;
using AspCoreUdemy.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreUdemy.Core.Data.Service.Mock
{
    public class MockApplicationRoleRepository : IApplicationRoleRepository
    {
        public MockApplicationRoleRepository()
        {

        }
        public Task Delete(ApplicationRole applicationRole)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationRole> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationRole> GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(ApplicationRole applicationRole)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task Edit(ApplicationRole applicationRole)
        {
            throw new NotImplementedException();
        }
    }
}
