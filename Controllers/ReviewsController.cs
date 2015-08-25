using MVCTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class ReviewsController : Controller
    {
        MVCTrainingDb _db = new MVCTrainingDb();

        // GET: Reviews
        public ActionResult Index(int? id)
        {
            var restaurant = _db.Restaurants.Find(id);
            if (restaurant != null)
            {
                return View(restaurant);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int? id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }



        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
