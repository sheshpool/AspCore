using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreUdemy.BackOffice.Web.UI.Controllers
{
    [Authorize]
    public class ResponseController : Controller
    {
        private readonly DefaultContext _context = null;

        public ResponseController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {

            var query = from item in this._context.Reponses.Include(r => r.Question)
                                                                .ThenInclude(q => q.Subject)
                                                                    .ThenInclude(s => s.Exam)
                        select item;

            return View(query.ToList());
        }

        public IActionResult Create()
        {
            

            this.ViewBag.ExamList = this._context.Exams.ToList();

            this.ViewBag.SubjectList = this._context.Subjects.ToList();

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
