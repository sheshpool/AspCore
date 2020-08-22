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
    public class QuestionController : Controller
    {
        private readonly DefaultContext _context = null;

        public QuestionController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {

            var query = from item in this._context.Questions
                        select item;
            return View(query.ToList());
        }

        public IActionResult Create()
        {
            this.ViewBag.ParagraphesList = this._context.Paragraphes.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Question question)
        {
            if (this.ModelState.IsValid)
            {
                this._context.Questions.Add(question);
                this._context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
