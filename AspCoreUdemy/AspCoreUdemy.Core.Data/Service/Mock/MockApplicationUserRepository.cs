using AspCoreUdemy.Core.Data.Infrastructure;
using AspCoreUdemy.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreUdemy.Core.Data.Service
{
    public class MockApplicationUserRepository : IApplicationUserRepository
    {
        public Task AffectRole(ApplicationUser applicationUser, ApplicationRole applicationRole)
        {
            throw new NotImplementedException();
        }

        public Task Delete(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task Edit(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> GetRolesByUser(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }
    }
}
