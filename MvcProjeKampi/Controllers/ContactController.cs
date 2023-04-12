using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator vm = new ContactValidator();
        public ActionResult Index()
        {
            var contactValues = cm.GetList();
            return View(contactValues);
        }
        public ActionResult GetContanctDetails(int id)
        {
            var contactValues = cm.GetByID(id);
            return View(contactValues);  
        }
        public PartialViewResult MessageListPartial()
        {
            return PartialView();
        }
    }
}