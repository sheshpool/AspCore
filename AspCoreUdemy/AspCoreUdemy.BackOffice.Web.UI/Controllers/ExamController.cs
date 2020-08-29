using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AspCoreUdemy.BackOffice.Web.UI.Controllers
{
    public class ExamController : Controller
    {
        private readonly DefaultContext _context = null;

        public ExamController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var query = from item in this._context.Exams
                        select item;
            return View(query.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Exam exam)
        {
            if(this.ModelState.IsValid)
            {
                this._context.Exams.Add(exam);
                this._context.SaveChanges();
            }

            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id)
        {
            Exam exam = null;

            exam = this._context.Exams.First(item => item.Id == id);

            return View(exam);
        }

        [HttpPost]
        public IActionResult Edit(Exam exam)
        {

            Exam examToEdit = null;
            examToEdit = this._context.Exams.First(item => item.Id == exam.Id);

            examToEdit.Titre = exam.Titre;
            examToEdit.Description = exam.Description;

            this._context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Exam exam = null;
            exam = this._context.Exams.First(item => item.Id == id);

            return View(exam);
        }

        public IActionResult Delete(int id)
        {
            Exam exam = null;
            exam = this._context.Exams.First(item => item.Id == id);

            return View(exam);
        }

        [HttpPost]
        public IActionResult Delete(Exam exam)
        {

            this._context.Remove(exam);

            this._context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
