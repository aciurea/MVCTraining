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
        MVCTrainingDb _db = new MVCTrainingDb();
        public ActionResult Index(string searchTerm = null)
        {

            var model = _db.Restaurants
                .OrderByDescending(r => r.Reviews.Count())
                .Take(10)
                .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                .Select(r => new RestaurantViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    Country = r.Country,
                    City = r.City,
                    CountOfReviews = r.Reviews.Count()
                });

            return View(model);
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
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}