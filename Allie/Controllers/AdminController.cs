﻿using AllieEntity;
using AllieService;
using AllieService.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Allie.Controllers
{
    public class AdminController : Controller
    {
        ICompanyServices service = ServiceFactory.GetCompanyServices();
        IUserServices uService = ServiceFactory.GetUserServices();
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Company> comp = ServiceFactory.GetCompanyServices().GetAll();
            return View(comp);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Company com = service.Get(id);
            
            return View(com);
        }
        [HttpPost]
        public ActionResult Edit(Company comp)
        {
            service.Update(comp);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            IEnumerable<User> userlist = uService.GetCompanyUsers(id);
            Company com = service.Get(id);
            ViewBag.CompanyDetails = com; 
            return View(userlist);
        }


        [HttpGet]
        public ActionResult EditUser(int id)
        {
            User user = uService.Get(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult EditUser(User user)
        {
            uService.Update(user);
            return RedirectToAction("ManageUserMaster");
        }

        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            service.Delete(id);
            return RedirectToAction("ManageUserMaster");
        }
    }
}