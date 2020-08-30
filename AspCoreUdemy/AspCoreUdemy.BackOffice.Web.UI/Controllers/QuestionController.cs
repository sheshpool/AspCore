using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            this.ViewBag.ExamList = this._context.Exams.ToList();

            this.ViewBag.SubjectList = this._context.Subjects.ToList();

            return View();
        }

        public JsonResult GetSubjectList(int examId)
        {
            List<Subject> listSubject = new List<Subject>();
            listSubject = (from subject in _context.Subjects
                           where subject.ExamId == examId
                           select subject).ToList();


            return Json(new SelectList(listSubject, "Id", "Titre"));
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
