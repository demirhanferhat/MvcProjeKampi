using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager ms = new MessageManager(new EfMessageDal());
        public ActionResult Inbox()
        {
            var messageList = ms.GetListInbox();
            return View(messageList);
        }
        public ActionResult Sendbox()
        {
            var messageList = ms.GetListSendbox();
            return View(messageList);
        }
        [HttpGet]
        public ActionResult NewMessage() 
        { 
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {

            return View();
        }
    }
}