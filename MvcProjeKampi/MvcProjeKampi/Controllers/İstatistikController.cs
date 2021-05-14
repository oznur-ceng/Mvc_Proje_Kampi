using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class İstatistikController : Controller
    {
        // GET: İstatistik
        Context context = new Context();

        public ActionResult Index()
        {
            var query_one = context.Categories.Count();
            ViewBag.query_one = query_one;

            var query_two = context.Headings.Count(x => x.CategoryID == 37);
            ViewBag.query_two = query_two;

            var query_three = context.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.query_three = query_three;

            var query_four = context.Headings.Max(x => x.Category.CategoryName);
            ViewBag.query_four = query_four;

            var query_five = context.Categories.Count(x => x.CategoryStatus == true);
            var query_six = context.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.query_five = query_five - query_six;
            return View();
        }
    }
}