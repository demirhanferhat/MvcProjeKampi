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
            var toplamSayi = db.Categories.Count(); // Toplam kategori sayısı 
            ViewBag.ToplamSayi = toplamSayi;

            var yazilimSayi = db.Headings.Count(x => x.HeadingName == "Yazılım").ToString(); //Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            ViewBag.YazilimSayi = yazilimSayi;

            var writerA = db.Writers.Count(x => x.WriterName.Contains("a")); //Yazar adında 'a' harfi geçen yazar sayısı
            ViewBag.WriterA = writerA;

            var enfazlaSayi = db.Headings.Max(x => x.Category.CategoryName); // En fazla başlığa sahip kategori adı
            ViewBag.EnfazlaSayi = enfazlaSayi;

            var truefalseFark = db.Categories.Count(x => x.CategoryStatus == true) - db.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.TruefalseFark = truefalseFark;

            var trueSayi = db.Categories.Count(x => x.CategoryStatus == true); // True Sayısı
            ViewBag.AktifSayi = trueSayi;

            var falseSayi = db.Categories.Count(x => x.CategoryStatus == false); // False Sayısı
            ViewBag.FalseSayi = falseSayi;

            var yazarSayisi = db.Writers.Count(); // Yazar Sayısı
            ViewBag.YazarSayisi = yazarSayisi;


            return View();
        }
    }
}