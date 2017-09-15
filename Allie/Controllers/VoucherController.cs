using AllieEntity;
using AllieService;
using AllieService.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Allie.Controllers
{
    public class VoucherController : Controller
    {
        IVoucherServices service = AllieService.ServiceFactory.GetVoucherServices();
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
                voucher.VoucherCreator = Convert.ToInt32(Session["UserId"]);
                ServiceFactory.GetVoucherServices().Insert(voucher);
                return RedirectToAction("Index", "UserHome");
            }
            return View(voucher);
        }
        [HttpGet]
        public ActionResult ManageVoucher()
        {
            
            return View(service.GetAll(Convert.ToInt32(Session["CompanyID"])));
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Voucher voucher = service.Get(id);
            return View(voucher);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            service.Delete(id);
            return RedirectToAction("ManageVoucher");
        }

        [HttpPost]
        public ActionResult Edit(Voucher v)
        {
            service.Update(v);
            return RedirectToAction("ManageVoucher");
        }

        [HttpGet]
        public ActionResult AssignOwner(int id)
        {
            ViewBag.AssignOwner = id;
            return View(ServiceFactory.GetUserServices().GetCompanyUsers(Convert.ToInt32(Session["CompanyID"])));
        }

        public ActionResult Assign(int VoucherId, int OwnerId)
        {
            Voucher voucher = service.Get(VoucherId);
            voucher.VoucherOwner = OwnerId;
            service.Update(voucher);
            return RedirectToAction("ManageVoucher");
        }
    }
}
