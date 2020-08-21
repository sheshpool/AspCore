using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreUdemy.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        private List<Paragraphe> paragraphes = new List<Paragraphe>()
        { 
        new Paragraphe(){Id = 1, Numero = 10, Titre = "Titre 1", Description = "Description 1"},
        new Paragraphe(){Id = 2, Numero = 20, Titre = "Titre 2", Description = "Description 2"},
        new Paragraphe(){Id = 3, Numero = 30, Titre = "Titre 3", Description = "Description 3"},
        new Paragraphe(){Id = 4, Numero = 40, Titre = "Titre 4", Description = "Description 4"},
        new Paragraphe(){Id = 5, Numero = 50, Titre = "Titre 5", Description = "Description 5"},
        new Paragraphe(){Id = 6, Numero = 60, Titre = "Titre 6", Description = "Description 6"},
        new Paragraphe(){Id = 7, Numero = 70, Titre = "Titre 7", Description = "Description 7"},
        new Paragraphe(){Id = 8, Numero = 80, Titre = "Titre 8", Description = "Description 8"},
        new Paragraphe(){Id = 9, Numero = 90, Titre = "Titre 9", Description = "Description 9"},
        new Paragraphe(){Id = 10, Numero = 100, Titre = "Titre 10", Description = "Description 10"}
        };

        public IActionResult Index()
        {
            return View(paragraphes);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;
            paragraphe = paragraphes.FirstOrDefault(x => x.Id == id);
            return View(paragraphe);
        }

        [HttpPost]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            int i = paragraphes.FindIndex(x => x.Id == paragraphe.Id);
            if(i>=0)
            {
                paragraphes[i] = paragraphe;
            }
                
            return View(paragraphe);
        }

        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            paragraphes.Add(paragraphe);
            return RedirectToAction("Index");
        }
    }
}
