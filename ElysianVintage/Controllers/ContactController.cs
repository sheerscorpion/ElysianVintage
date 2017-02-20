using ElysianVintage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElysianVintage.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(MailingListingModel message)
        {
            string emailAddress = message.emailAddress;
            bool mailingList = message.mailingList;

            return View();
        }
        
    }
}