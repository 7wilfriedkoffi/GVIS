using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionVisiteur.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Modele()
        {
            return View();
        }

        public ActionResult Formulaire()
        {
            return View();
        }
        public ActionResult Pageexemple()
        {
            return View();
        }

        public ActionResult GetParamètres()
        {
            return View();
        }
    }
}