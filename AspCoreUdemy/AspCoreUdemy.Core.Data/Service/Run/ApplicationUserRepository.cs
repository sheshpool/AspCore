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
            List<string> applicationRolesList = (List<string>)await this._userManager.GetRolesAsync(applicationUser);
            return applicationRolesList;
        }

        public async Task Edit(ApplicationUser applicationUser, List<string> roles)
        {
            var _applicationUser = (ApplicationUser)await this._userManager.FindByIdAsync(applicationUser.Id);
            _applicationUser.FirstName = applicationUser.FirstName;
            _applicationUser.LastName = applicationUser.LastName;
            _applicationUser.Email = applicationUser.Email;
            _applicationUser.UserName = applicationUser.UserName;

            // Apply the changes if any to the db
            await _userManager.UpdateAsync(_applicationUser);


            List<ApplicationRole> applicationRoles = this._applicationRoleRepository.GetAll();

            foreach (ApplicationRole applicationRole in applicationRoles)
            {
                if (roles.Contains(applicationRole.RoleName))
                {
                    if (!await this._userManager.IsInRoleAsync(_applicationUser, applicationRole.Name))
                    {
                        var result = await this._userManager.AddToRoleAsync(_applicationUser, applicationRole.Name);
                    }
                }
                else
                {
                    if (await this._userManager.IsInRoleAsync(_applicationUser, applicationRole.Name))
                    {
                        var result = await this._userManager.RemoveFromRoleAsync(_applicationUser, applicationRole.Name);
                    }
                }
            }
        }

        public async Task Create(ApplicationUser applicationUser, List<string> roles, string password)
        {
            
            IdentityResult result = await _userManager.CreateAsync(applicationUser, password);


            if (result.Succeeded)
            {
                foreach (string role in roles)
                {

                    var newRole = new ApplicationRole() { RoleName = role, Name = role, NormalizedName = role, CreationDateTime = DateTime.Now };

                    var roleExist = await _roleManager.RoleExistsAsync(role);

                    if (!roleExist)
                    {
                        var resultRole = await _roleManager.CreateAsync(newRole);
                    }

                    if (result.Succeeded)
                    {
                        var result1 = await _userManager.AddToRoleAsync(applicationUser, role);
                    }
                }
            }
        }
    }
}
