using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspCoreUdemy.Core.Data.Models;
using AspCoreUdemy.Core.Data;

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

                result = RedirectToAction("ExamBegin");
            }
            return result;
        }

        IActionResult ExamBegin()
        {

            return View();
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
