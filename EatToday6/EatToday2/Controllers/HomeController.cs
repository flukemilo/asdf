using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EatToday2.Controllers
{
    public class HomeController : Controller
    {
        EatToday2.EatTodayEntities _db = new EatToday2.EatTodayEntities();

        public DateTime yesterday = DateTime.Now.Date.AddDays(-1);

        public ActionResult Index()
        {
            var model
                = _db.Restaurants
                    .OrderByDescending(r => r.Ratings.Average(review => review.RatingValue))
                    .Where(r => r.LastVisit < yesterday)
                    .Take(1);
 
            return View(model);
        }

        public ActionResult LunchToday()
        {
            var model = _db.Restaurants.Take(2);

            return View(model);
        }

        public ActionResult Contacts()
        {
            var model = _db.Restaurants.Take(2);

            return View(model);
        }

        public JsonResult GetJason()
        {
            EatTodayEntities e = new EatTodayEntities();
            var result = e.Restaurants.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}