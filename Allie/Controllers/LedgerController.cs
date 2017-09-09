using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Allie.Controllers
{
    public class LedgerController : Controller
    {
        // GET: Ledger
        public ActionResult CreateTransaction()
        {
            return View();
        }
        public ActionResult ManageTransaction()
        {
            return View();
        }

    }
}