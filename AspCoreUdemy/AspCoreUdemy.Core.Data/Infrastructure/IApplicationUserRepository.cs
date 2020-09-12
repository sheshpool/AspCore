using AspCoreUdemy.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreUdemy.Core.Data.Infrastructure
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();
        Task<ApplicationUser> GetById(string id);
        Task Edit(ApplicationUser applicationUser, List<string> roles);
        Task Create(ApplicationUser applicationUser, List<string> roles, string password);
        Task Delete(ApplicationUser applicationUser);
        Task<List<String>> GetRolesByUser(ApplicationUser applicationUser);
    }
}