using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        Context db = new Context();
        // GET: Istatistik
        public ActionResult Index()
        {
            var toplamSayi = db.Categories.Count();
            ViewBag.ToplamSayi = toplamSayi;

            var trueSayi = db.Categories.Count(x => x.CategoryStatus == true);
            ViewBag.AktifSayi = trueSayi;

            var falseSayi = db.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.FalseSayi = falseSayi;

            var enfazlaSayi = db.Headings.Max(x => x.Category.CategoryName);
            ViewBag.EnfazlaSayi = enfazlaSayi;


            return View();
        }
    }
}