using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreUdemy.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        private readonly DefaultContext _context = null;

        public ParagrapheController(DefaultContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var query = from item in this._context.Paragraphes
                        select item;
            return View(query.ToList());
        }



        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;
            paragraphe = this._context.Paragraphes.First(item => item.Id == id);         
             
            return View(paragraphe);
        }

        [HttpPost]
        public IActionResult Edit(Paragraphe paragraphe)
        {

            Paragraphe paragrapheToEdit = null;
            paragrapheToEdit = this._context.Paragraphes.First(item => item.Id == paragraphe.Id);

            paragrapheToEdit.Numero = paragraphe.Numero;
            paragrapheToEdit.Titre = paragraphe.Titre;
            paragrapheToEdit.Description = paragraphe.Description;

            this._context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            this._context.Paragraphes.Add(paragraphe);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Paragraphe paragraphe = null;
            paragraphe = this._context.Paragraphes.First(item => item.Id == id);

            return View(paragraphe);
        }

        [HttpPost]
        public IActionResult Delete(Paragraphe paragraphe)
        {

            this._context.Remove(paragraphe);

            this._context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Paragraphe paragraphe = null;
            paragraphe = this._context.Paragraphes.First(item => item.Id == id); 
            
            return View(paragraphe);
        }
    }
}
