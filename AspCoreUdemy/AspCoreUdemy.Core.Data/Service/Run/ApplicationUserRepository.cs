using AspCoreUdemy.Core.Data.Infrastructure;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCoreUdemy.Core.Data.Service.Run
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly DefaultContext _context = null;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationRoleRepository _applicationRoleRepository;

        public ApplicationUserRepository
            (
                DefaultContext context, 
                RoleManager<ApplicationRole> roleManager, 
                UserManager<ApplicationUser> userManager,
                IApplicationRoleRepository applicationRoleRepository
            )
        {
            this._context = context;
            this._roleManager = roleManager;
            this._userManager = userManager;
            this._applicationRoleRepository = applicationRoleRepository;
        }

        public async Task Delete(ApplicationUser applicationUser)
        {
            var user = await this._userManager.FindByIdAsync(applicationUser.Id);
            var result = await this._userManager.DeleteAsync(user);
        }

        public List<ApplicationUser> GetAll()
        {
            var userList = _userManager.Users.ToList();

            var ll = (from item in userList
                      orderby item.CreationDateTime descending
                      select item).ToList();

            return ll;
        }

        public async Task<ApplicationUser> GetById(string id)
        {
            ApplicationUser applicationUser = await this._userManager.FindByIdAsync(id);
            return applicationUser;
        }

        public async Task<List<string>> GetRolesByUser(ApplicationUser applicationUser)
        {
            List<string> applicationRolesList  = (List<string>)await this._userManager.GetRolesAsync(applicationUser);
            return applicationRolesList;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public async Task AffectRoles(ApplicationUser applicationUser, List<string> roles)
        {
            List<ApplicationRole> applicationRoles = this._applicationRoleRepository.GetAll();

            foreach (ApplicationRole applicationRole in applicationRoles)
            {
                if(roles.Contains(applicationRole.RoleName))
                {
                    if (!await this._userManager.IsInRoleAsync(applicationUser, applicationRole.Name))
                    {
                        var result = await this._userManager.AddToRoleAsync(applicationUser, applicationRole.Name); 
                    }
                }
                else
                {
                    if (await this._userManager.IsInRoleAsync(applicationUser, applicationRole.Name))
                    {
                        var result = await this._userManager.RemoveFromRoleAsync(applicationUser, applicationRole.Name);
                    }
                }                
            }
        }

        public Task Insert(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

        public async Task Edit(ApplicationUser applicationUser)
        {

            // Get the existing student from the db
            var _applicationUser = (ApplicationUser) await this._userManager.FindByIdAsync(applicationUser.Id);

            // Update it with the values from the view model
            _applicationUser.FirstName = applicationUser.FirstName;
            _applicationUser.LastName = applicationUser.LastName;
            _applicationUser.Email = applicationUser.Email;

            // Apply the changes if any to the db
            await _userManager.UpdateAsync(_applicationUser);
        }
    }
}
