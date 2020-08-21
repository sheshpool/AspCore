using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspCoreUdemy.Core.Data.Models ;
using AspCoreUdemy.Core.Data;

namespace Web.UI.Controllers
{
    public class AventureController : Controller
    {
        private readonly DefaultContext _context = null;

        public AventureController(DefaultContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Aventures";

            var query = from item in this._context.Aventures
                        select item;

            return View(query.ToList());
        }
    }
}
