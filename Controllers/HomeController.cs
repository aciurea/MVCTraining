using MVCTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            var message = String.Format("{0} {1} {2}", controller, action, id);

            ViewBag.Message = message;
            return View();
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "John Snow";
            model.Location = "The Wall";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}