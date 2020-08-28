using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using Microsoft.AspNetCore.Mvc;

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
    }
}
