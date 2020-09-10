using AspCoreUdemy.Core.Data.Infrastructure;
using AspCoreUdemy.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using Microsoft.AspNetCore.Identity;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AspCoreUdemy.Core.Data.Service.Run
{
    public class ApplicationRoleRepository : IApplicationRoleRepository
    {
        private readonly DefaultContext _context = null;
        private readonly RoleManager<ApplicationRole> _roleManager;


        public ApplicationRoleRepository(DefaultContext context, RoleManager<ApplicationRole> roleManager)
        {
            this._context = context;
            this._roleManager = roleManager;
        }

        public async Task Delete(ApplicationRole applicationRole)
        {
            var role = await this._roleManager.FindByIdAsync(applicationRole.Id);
            var result = await this._roleManager.DeleteAsync(role);
        }

        public List<ApplicationRole> GetAll()
        {
            var roleList = _roleManager.Roles.ToList();

            var ll = (from item in roleList
                     orderby item.CreationDateTime descending
                     select item).ToList();
                     
            return ll;
        }

        public async Task<ApplicationRole> GetById(string id)
        {
            ApplicationRole applicationRole = await this._roleManager.FindByIdAsync(id);
            return applicationRole;
        }

        public async Task Insert(ApplicationRole applicationRole)
        {
            var newRole = new ApplicationRole() 
            { 
                RoleName = applicationRole.RoleName, 
                Name = applicationRole.RoleName, 
                NormalizedName = applicationRole.RoleName, 
                CreationDateTime = DateTime.Now 
            };

            var roleExist = await _roleManager.RoleExistsAsync(applicationRole.RoleName);

            if (!roleExist)
            {
                var result = await _roleManager.CreateAsync(newRole);
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public async Task Edit(ApplicationRole applicationRole)
        {
            ApplicationRole role = await this._roleManager.FindByIdAsync(applicationRole.Id);

            role.RoleName = applicationRole.RoleName;
            role.Name = applicationRole.Name;
            role.NormalizedName = applicationRole.RoleName.ToUpper();

            await _roleManager.UpdateAsync(role);
        }
    }
}
