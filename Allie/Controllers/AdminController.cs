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
    public class AdminController : Controller
    {
        ICompanyServices service = ServiceFactory.GetCompanyServices();
        IUserServices uService = ServiceFactory.GetUserServices();
        IUserTypeServices TService = ServiceFactory.GetUserTypeServices();
        static UserType userType; 
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
        [HttpGet]
        public ActionResult Type()
        {
            IEnumerable<UserType> comp = TService.GetAll();
            ViewBag.TypeList = comp;
            return View(comp);
        }

        [HttpGet]
        public ActionResult EditType(int id)
        {
            UserType user = TService.Get(id);
            userType = user;
            return View(user);
        }

        //[HttpPost]
        //public ActionResult EditType(UserType type)
        //{
        //    //userType.Type = type.Type;
        //    TService.Update(userType);
        //    return RedirectToAction("Admin");
        //}
        [HttpPost]
        public ActionResult EditType(string Type)
        {
            userType.Type = Type;
            TService.Update(userType);
            return RedirectToAction("Type","Admin");
        }
        [HttpGet]
        public ActionResult CreateType()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateType(UserType user)
        {
            if (ModelState.IsValid)
            {
                
                TService.Insert(user);
                return RedirectToAction("Type", "Admin");
            }


            return View(user);
        }
        [HttpGet]
        public ActionResult DeleteType(int id )
        {
            TService.Delete(id);
            return RedirectToAction("Type", "Admin");
        }
    }
}