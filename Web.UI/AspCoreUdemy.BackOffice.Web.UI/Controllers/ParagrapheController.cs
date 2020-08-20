using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreUdemy.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = new Paragraphe() { Id = id, Titre = "Titre du paragraphe", Description = "Description du paragraphe", Numero = 10 };
            return View(paragraphe);
        }

        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {

            return RedirectToAction("Create");
        }
    }
}
