using AllieEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Allie.Controllers
{
    public class JournalController : Controller
    {
        // GET: Jornal
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateJournal()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateJournal(Journal journal )
        {
            AllieService.ServiceFactory.GetJournalServices().Insert(journal);
            return RedirectToAction("Index", "UserHome");
        }
        [HttpGet]
        public ActionResult ManageJournal()
        {
            return View();
        }
        
    }
}