using AspCoreUdemy.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreUdemy.Core.Data.Infrastructure
{
    public interface IApplicationRoleRepository
    {
        List<ApplicationRole> GetAll();
        Task<ApplicationRole> GetById(string Id);
        Task Insert(ApplicationRole applicationRole);
        Task Edit(ApplicationRole applicationRole);
        Task Delete(ApplicationRole applicationRole);
        void Save();
    }
}
