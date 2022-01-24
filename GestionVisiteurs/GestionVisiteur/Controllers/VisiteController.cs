using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionVisiteur.Controllers
{
    public class VisiteController : Controller
    {
        // GET: Visite
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreerVisite()
        {
            return View();
        }

        public ActionResult ListeVisite()
        {
            return View();
        }
    }
}