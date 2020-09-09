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


namespace AspCoreUdemy.CoreApp.Web.UI.Controllers
{
    public class ApplicationUserController : Controller
    {
        private readonly DefaultContext _context = null;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserController(DefaultContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            this._context = context;
            this._roleManager = roleManager;
            this._userManager = userManager;
        }
        public IActionResult Index()
        {

            var result = _context.ApplicationUserRoles
                .ToList();

            return View(result);
        }
    }
}
