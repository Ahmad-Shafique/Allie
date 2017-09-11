using AllieEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AllieService;

namespace Allie.Controllers
{
    public class LedgerController : Controller
    {
        //IServices service = ServiceFactory.GetUserServices();
        // GET: Ledger
        [HttpGet]
        public ActionResult CreateLedger()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateLedger(Ledger ledger)
        {
            if (ModelState.IsValid)
            {
               
                ServiceFactory.GetLedgerServices().Insert(ledger);
                return RedirectToAction("Index", "UserHome");
            }


            return View(ledger);
        }
        public ActionResult ManageLedger()
        {
            return View();
        }

    }
}