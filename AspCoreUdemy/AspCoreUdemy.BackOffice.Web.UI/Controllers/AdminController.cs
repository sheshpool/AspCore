using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreUdemy.BackOffice.Web.UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public AdminController(RoleManager<ApplicationRole> roleManager)
        {
            this._roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(ApplicationRole role)
        {
            var roleExist = await _roleManager.RoleExistsAsync(role.RoleName);
            if(!roleExist)
            {
                var result = await _roleManager.CreateAsync(role);
            }
            return View();
        }
    }
}
