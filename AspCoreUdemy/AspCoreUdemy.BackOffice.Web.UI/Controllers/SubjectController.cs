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
    public class SubjectController : Controller
    {
        private readonly DefaultContext _context = null;

        public SubjectController(DefaultContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var query = from item in this._context.Subjects
                        select item;
            return View(query.ToList());
        }



        public IActionResult Edit(int id)
        {
            Subject paragraphe = null;
            paragraphe = this._context.Subjects.First(item => item.Id == id);         
             
            return View(paragraphe);
        }

        [HttpPost]
        public IActionResult Edit(Subject subject)
        {

            Subject paragrapheToEdit = null;
            paragrapheToEdit = this._context.Subjects.First(item => item.Id == subject.Id);

            paragrapheToEdit.Titre = subject.Titre;
            paragrapheToEdit.Description = subject.Description;

            this._context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            List<Exam> examList = new List<Exam>(); 
            
            examList = this._context.Exams.ToList();
            examList.Insert(0, new Exam { Id = 0, Titre = "Select exam"});

            this.ViewBag.ExamList = examList;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Subject subject)
        {

            if (this.ModelState.IsValid)
            {
                this._context.Subjects.Add(subject);
                this._context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Subject paragraphe = null;
            paragraphe = this._context.Subjects.First(item => item.Id == id);

            return View(paragraphe);
        }

        [HttpPost]
        public IActionResult Delete(Subject paragraphe)
        {

            this._context.Remove(paragraphe);

            this._context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Subject paragraphe = null;
            paragraphe = this._context.Subjects.First(item => item.Id == id); 
            
            return View(paragraphe);
        }
    }
}
