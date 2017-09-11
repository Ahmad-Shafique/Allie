using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AllieEntity;

namespace Allie.Controllers
{
    public class CompanyController : BaseController
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Company company )
        {
            Company newCompany = AllieService.ServiceFactory.GetCompanyServices().Insert(company);
            Session["CompanyId"] = newCompany.Id;
            return RedirectToAction("CreateUser", "User");
        }
        public ActionResult Home()
        {
            return RedirectToAction("Index", "Home");
        }


    }
}