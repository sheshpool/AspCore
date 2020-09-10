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
        //private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserRepository(DefaultContext context, RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this._context = context;
            //this._roleManager = roleManager;
            this._userManager = userManager;
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

        public async Task<IList<string>> GetRolesByUser(ApplicationUser applicationUser)
        {
            IList<string> applicationRolesList  = await this._userManager.GetRolesAsync(applicationUser);
            return applicationRolesList;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task AffectRole(ApplicationUser applicationUser, ApplicationRole applicationRole)
        {
            throw new NotImplementedException();
        }

        public Task Insert(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }

        public async Task Edit(ApplicationUser applicationUser)
        {
            ApplicationUser user = await this._userManager.FindByIdAsync(applicationUser.Id);

            user.FirstName = applicationUser.UserName;
            user.LastName = applicationUser.LastName;
            user.Email = applicationUser.Email;

            await _userManager.UpdateAsync(user);
        }
    }
}
