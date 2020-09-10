using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using AspCoreUdemy.Core.Data.Infrastructure;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreUdemy.BackOffice.Web.UI.Controllers
{
    [Authorize]
    public class ApplicationRoleController : Controller
    {
        private readonly DefaultContext _context = null;
        private readonly IApplicationRoleRepository _applicationRoleRepository;

        public ApplicationRoleController(DefaultContext context, RoleManager<ApplicationRole> roleManager, IApplicationRoleRepository applicationRoleRepository)
        {
            this._context = context;
            this._applicationRoleRepository = applicationRoleRepository;
        }

        public IActionResult Index()
        {
            var applicationRoles = this._applicationRoleRepository.GetAll();
            return View(applicationRoles);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Details(string id)
        {
            ApplicationRole applicationRole = await _applicationRoleRepository.GetById(id);
            return View(applicationRole);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ApplicationRole role)
        {
            await this._applicationRoleRepository.Insert(role);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            var applicationRole =  await this._applicationRoleRepository.GetById(id);
            return View(applicationRole);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ApplicationRole applicationRole)
        {
            await this._applicationRoleRepository.Delete(applicationRole);

            //var role = await this._roleManager.FindByIdAsync(applicationRole.Id);
            //var result = await this._roleManager.DeleteAsync(role);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(string id)
        {
            var applicationRole = await this._applicationRoleRepository.GetById(id);
            return View(applicationRole);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ApplicationRole applicationRole)
        {
            await this._applicationRoleRepository.Edit(applicationRole);

            return RedirectToAction("Index");
        }
    }
}
