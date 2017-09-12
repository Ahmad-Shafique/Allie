using AllieEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AllieService;
using System.Web.Services.Description;
using AllieService.ServiceInterfaces;

namespace Allie.Controllers
{
    public class LedgerController : Controller
    {
        ILedgerServices service = ServiceFactory.GetLedgerServices();
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
        [HttpGet]
        public ActionResult ManageLedger()
        {
            IEnumerable<AllieEntity.Ledger> LedgerList=ServiceFactory.GetLedgerServices().GetAll();
            return View(LedgerList);
 
        }
        [HttpGet]
        public ActionResult Edit(Ledger ledger)
        {
            service.Update(ledger);
            return RedirectToAction("ManageLedger");

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            service.Delete(id);
            return RedirectToAction("ManageLedger");

        }
    }
}