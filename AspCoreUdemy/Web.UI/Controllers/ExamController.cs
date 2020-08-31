using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspCoreUdemy.Core.Data.Models;
using AspCoreUdemy.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Razor.Language;

namespace Web.UI.Controllers
{
    public class ExamController : Controller
    {
        private readonly DefaultContext _context = null;

        public ExamController(DefaultContext context)
        {
            this._context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Exam exam)
        {
            ActionResult result = View();

            if (this.ModelState.IsValid)
            {
                this._context.Exams.Add(exam);
                this._context.SaveChanges();

                result = RedirectToAction("ExamStart");
            }
            return result;
        }

        public IActionResult ExamStart(int examId)
        {
            var query = from item in this._context.Exams.Include(e => e.Subjects)
                                                            .ThenInclude(s => s.Questions)
                                                                .ThenInclude(q => q.Responses)
                        where item.Id == examId
                        select item;
    
            return View(query.ToList().First());
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Exams";

            var query = from item in this._context.Exams
                        select item;

            return View(query.ToList());
        }
    }
}
