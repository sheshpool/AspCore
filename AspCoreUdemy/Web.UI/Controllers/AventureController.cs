using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspCoreUdemy.Core.Data.Models ;
using AspCoreUdemy.Core.Data;

namespace Web.UI.Controllers
{
    public class AventureController : Controller
    {
        private readonly DefaultContext _context = null;

        public AventureController(DefaultContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Aventures";

            var query = from item in this._context.Aventures
                        select item;



            List < Aventure > aventures = new List<Aventure>();
            aventures.Add(new Aventure() { Id = 1, Titre = "Ma première aventure" });
            aventures.Add(new Aventure() { Id = 2, Titre = "Ma seconde aventure" });
            aventures.Add(new Aventure() { Id = 3, Titre = "Ma troisièrme aventure" });

            return View(query.ToList());
        }
    }
}
