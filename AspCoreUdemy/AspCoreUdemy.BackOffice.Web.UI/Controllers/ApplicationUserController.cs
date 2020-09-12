using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspCoreUdemy.Core.Data.Infrastructure;
using AspCoreUdemy.BackOffice.Web.UI.Models;

namespace AspCoreUdemy.CoreApp.Web.UI.Controllers
{
    [Authorize]
    public class ApplicationUserController : Controller
    {
        private readonly DefaultContext _context = null;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IApplicationRoleRepository _applicationRoleRepository;

        public ApplicationUserController(
                DefaultContext context, 
                IApplicationUserRepository applicationUserRepository, 
                IApplicationRoleRepository applicationRoleRepository
            )
        {
            this._context = context;
            this._applicationUserRepository = applicationUserRepository;
            this._applicationRoleRepository = applicationRoleRepository;
        }
        public async Task<IActionResult> Index()
        {
            List<UserRoleViewModel> userRoleViewModelList = new List<UserRoleViewModel>();
            var applicationUsers = this._applicationUserRepository.GetAll();
            foreach(ApplicationUser ApplicationUser in applicationUsers)
            {

                List<string> strRoles = await this._applicationUserRepository.GetRolesByUser(ApplicationUser);

                List<RoleCheckBox> applicationRolesCheckBox = new List<RoleCheckBox>();


                foreach (ApplicationRole role in this._applicationRoleRepository.GetAll())
                {
                    if (strRoles.Contains(role.RoleName))
                    {
                        applicationRolesCheckBox.Add(new RoleCheckBox { ApplicationRole = role, IsChecked = true });
                    }
                    else
                    {
                        applicationRolesCheckBox.Add(new RoleCheckBox { ApplicationRole = role, IsChecked = true });
                    }

                }

                userRoleViewModelList.Add(item: new UserRoleViewModel { ApplicationUser = ApplicationUser, ApplicationRolesCheckBox = applicationRolesCheckBox });
                
            }



            return View(userRoleViewModelList);
        }

        public async Task<IActionResult> Details(string id)
        {
            ApplicationUser applicationUser = await _applicationUserRepository.GetById(id);
            return View(applicationUser);
        }
        public async Task<IActionResult> Delete(string id)
        {
            var applicationUser = await this._applicationUserRepository.GetById(id);
            return View(applicationUser);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ApplicationUser applicationUser)
        {
            await this._applicationUserRepository.Delete(applicationUser);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(string id)
        {
            ApplicationUser ApplicationUser = await this._applicationUserRepository.GetById(id);
            List<string> strRoles = await this._applicationUserRepository.GetRolesByUser(ApplicationUser);

            List<RoleCheckBox> applicationRolesCheckBox = new List<RoleCheckBox>();


            foreach (ApplicationRole role in this._applicationRoleRepository.GetAll())
            {
                if(strRoles.Contains(role.RoleName))
                {
                    applicationRolesCheckBox.Add(new RoleCheckBox { ApplicationRole = role, IsChecked = true });
                }
                else
                {
                    applicationRolesCheckBox.Add(new RoleCheckBox { ApplicationRole = role, IsChecked = false });
                }

            }

            this.ViewBag.RoleList = this._applicationRoleRepository.GetAll();


            UserRoleViewModel userRoleViewModel = new UserRoleViewModel { ApplicationUser = ApplicationUser, ApplicationRolesCheckBox = applicationRolesCheckBox };
            return View(userRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserRoleViewModel userRoleViewModel)
        {
            List<string> roles = new List<string>();
            foreach(RoleCheckBox roleCheckBox in userRoleViewModel.ApplicationRolesCheckBox)
            {
                if (roleCheckBox.IsChecked)
                {
                    roles.Add(roleCheckBox.ApplicationRole.RoleName);
                }
            }

            await this._applicationUserRepository.Edit(userRoleViewModel.ApplicationUser, roles);

            return RedirectToAction("Index");
        }
    }
}