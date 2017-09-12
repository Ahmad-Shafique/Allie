using AllieEntity;
using AllieService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Allie.Controllers
{
    public class VoucherController : Controller
    {
        // GET: Voucher
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateVoucher()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateVoucher(Voucher voucher)
        {
            if (ModelState.IsValid)
            {

                //ServiceFactory.GetVoucherServices.Insert(voucher);
                return RedirectToAction("Index", "UserHome");
            }
            return View(voucher);
        }
        [HttpGet]
        public ActionResult ManageVoucher()
        {
            return View();
        }
    }
}