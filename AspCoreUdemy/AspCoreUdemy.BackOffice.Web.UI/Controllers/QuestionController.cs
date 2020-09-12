using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AspCoreUdemy.BackOffice.Web.UI.Controllers
{
    [Authorize(Roles = "Admin, Contributor")]
    public class QuestionController : Controller
    {
        private readonly DefaultContext _context = null;

        public QuestionController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {

            var query = from item in this._context.Questions.Include(q => q.Subject)
                                                                .ThenInclude(s => s.Exam)
                        select item;
            return View(query.ToList());
        }

        public JsonResult GetQuestionListBySubject(int subjectId, string viewCaller)
        {
            List<Question> listQuestion = new List<Question>();
            listQuestion = (from question in _context.Questions
                           where question.SubjectId == subjectId
                            select question).ToList();


            return Json(new SelectList(listQuestion, "Id", "Titre"));
        }

        public IActionResult Create()
        {
            this.ViewBag.ExamList = this._context.Exams.ToList();

            this.ViewBag.SubjectList = this._context.Subjects.ToList();

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


        public IActionResult Delete(int id)
        {
            Question question = null;
            question = this._context.Questions.First(item => item.Id == id);

            return View(question);
        }

        [HttpPost]
        public IActionResult Delete(Question question)
        {

            this._context.Remove(question);

            this._context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Question question = null;
            question = this._context.Questions.First(item => item.Id == id);

            this.ViewBag.SubjectList = this._context.Subjects.ToList();

            return View(question);
        }

        [HttpPost]
        public IActionResult Edit(Question question)
        {

            Question questionToEdit = null;
            questionToEdit = this._context.Questions.First(item => item.Id == question.Id);

            questionToEdit.SubjectId = question.SubjectId;
            questionToEdit.Titre = question.Titre;

            this._context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Question question = null;
            question = this._context.Questions.First(item => item.Id == id);

            return View(question);
        }


    }
}
