using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutoWebApplication1.Controllers
{
    public class TutoController : Controller
    {
        // GET: TutoController
        public ActionResult Index()
        {
            //return View();
            return new ContentResult { Content = "Ceci est la liste des Tuto" };
        }

        // GET: TutoController/Details/5
        public ActionResult Details(int id)
        {
            //return View();
            if (id == 0)
            {
                return RedirectToAction("Index", "Home");
                //return new ContentResult { Content = "Ooops une erreur certainement.... " + id };
            }
            else
            {
                return new ContentResult { Content = "Ceci est la page du Tuto " + id };
            }

        }

        // GET: TutoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
