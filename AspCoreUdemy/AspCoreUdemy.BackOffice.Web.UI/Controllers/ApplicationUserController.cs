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
        public IActionResult Index()
        {

            var applicationUsers = this._applicationUserRepository.GetAll();
            return View(applicationUsers);
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
            var applicationUser = await this._applicationUserRepository.GetById(id);
            this.ViewBag.RoleList = this._applicationRoleRepository.GetAll();

            return View(applicationUser);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ApplicationUser applicationUser)
        {
            await this._applicationUserRepository.Edit(applicationUser);

            return RedirectToAction("Index");
        }
    }
}
