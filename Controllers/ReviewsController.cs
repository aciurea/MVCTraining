using MVCTraining.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class ReviewsController : Controller
    {
        MVCTrainingDb _db = new MVCTrainingDb();

        // GET: Reviews
        public ActionResult Index([Bind(Prefix = "id")] int? restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                return View(restaurant);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int? restaurantId)
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
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }

        public ActionResult Delete(int? id)
        {
            var model = _db.Reviews.Find(id);
            if (model == null)
            { return HttpNotFound(); }
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            var model = _db.Reviews.Find(id);
            _db.Reviews.Remove(model);
            _db.SaveChanges();
            return RedirectToAction("Index", new { id = model.RestaurantId });
        }


        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
