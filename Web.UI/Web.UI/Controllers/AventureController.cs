using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Aventure";
            ViewBag.Tableau = new string[] { "Aventure 1", "Aventure 2", "Aventure 3", "Aventure 4", "Aventure 5" };
            return View();
        }
    }
}
