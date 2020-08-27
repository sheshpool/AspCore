using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreUdemy.BackOffice.Web.UI.Controllers
{
    public class ResponseController : Controller
    {
        private readonly DefaultContext _context = null;

        public ResponseController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {

            var query = from item in this._context.Reponses
                        select item;
            return View(query.ToList());
        }

        public IActionResult Create()
        {
            this.ViewBag.QuestionList = this._context.Questions.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Response reponse)
        {
            if (this.ModelState.IsValid)
            {
                this._context.Reponses.Add(reponse);
                this._context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            Response reponse = null;
            reponse = this._context.Reponses.First(item => item.Id == id);

            return View(reponse);
        }

        [HttpPost]
        public IActionResult Delete(Response reponse)
        {

            this._context.Remove(reponse);

            this._context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Response reponse = null;
            reponse = this._context.Reponses.First(item => item.Id == id);

            this.ViewBag.QuestionList = this._context.Questions.ToList();

            return View(reponse);
        }

        [HttpPost]
        public IActionResult Edit(Response reponse)
        {

            Response reponseToEdit = null;
            reponseToEdit = this._context.Reponses.First(item => item.Id == reponse.Id);

            reponseToEdit.QuestionId = reponse.QuestionId;
            reponseToEdit.Description = reponse.Description;

            this._context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Response reponse = null;
            reponse = this._context.Reponses.First(item => item.Id == id);

            return View(reponse);
        }
    }
}
