using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreUdemy.BackOffice.Web.UI.Controllers
{
    public class ApplicationRoleController : Controller
    {
        private readonly DefaultContext _context = null;
        private RoleManager<ApplicationRole> _roleManager;

        public ApplicationRoleController(DefaultContext context, RoleManager<ApplicationRole> roleManager)
        {
            this._context = context;
            this._roleManager = roleManager;
        }

        public IActionResult Index()
        {

            var query = from item in this._context.ApplicationRoles
                        orderby item.CreationDateTime descending
                        select item;

             return View(query.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(ApplicationRole role)
        {
            var newRole = new ApplicationRole() { RoleName = role.RoleName, Name = role.RoleName, NormalizedName = role.RoleName, CreationDateTime = DateTime.Now };

            var roleExist = await _roleManager.RoleExistsAsync(role.RoleName);

            if(!roleExist)
            {
                var result = await _roleManager.CreateAsync(newRole);
            }
            return RedirectToAction("Index");
        }
    }
}
