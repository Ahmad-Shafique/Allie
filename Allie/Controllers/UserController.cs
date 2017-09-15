using AllieEntity;
using System.Collections.Generic;
using System.Web.Mvc;
using Allie.Models;
using AllieService.ServiceInterfaces;
using AllieService;
using System;

namespace Allie.Controllers
{
    public class UserController : Controller
    {
        IUserServices service = ServiceFactory.GetUserServices();


        // GET: User
        public ActionResult Index()
        {
            IEnumerable<User> userlist = service.GetAll(); 

            List<UserModel> userview = new List<UserModel>(); 

            

            foreach (User u in userlist)
            {
                UserModel user = new UserModel()
                {
                    UserId = u.UserId,
                    UserName = u.UserName,
                    Phone = u.Phone,
                    Password = u.Password,
                    Email = u.Email,
                    UserType = u.UserType,
                    Address = u.Address,
                    CompanyId = u.CompanyId
                    
                };

                userview.Add(user);
            }

            return View("UserView");
        }

        [HttpPost]
        public ActionResult ManageUserMaster(FormCollection form)
        {
            string SearchString = form["SearchText"].ToString();
            IEnumerable<User> Results = service.GetCompanyUsers(Convert.ToInt32(Session["CompanyID"]));
            List<User> items = new List<AllieEntity.User>();
            foreach (User user in Results)
            {
                if (user.UserName.Contains(SearchString)) items.Add(user);
            }
            Results = items;
            return View("ManageUserMaster", Results);
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            if (ModelState.IsValid) {
                user.CompanyId = Convert.ToInt32(Session["CompanyId"].ToString());
                service.Insert(user);
                return RedirectToAction("Index","UserHome");
            }
            
            
            return View(user);
        }

        [HttpGet]
        public ActionResult ManageUserMaster()
        {
            if (Session["CompanyID"] != null)
            {
                IEnumerable<AllieEntity.User> UsersList = service.GetCompanyUsers(Convert.ToInt32(Session["CompanyID"].ToString()));

                return View(UsersList);
            }
            return RedirectToAction("Index", "UserHome");
        }

        [HttpGet]
        public ActionResult Edit(int id) {
            User user = service.Get(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            service.Update(user);
            return RedirectToAction("ManageUserMaster");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            service.Delete(id);
            return RedirectToAction("ManageUserMaster");
        }
        
        //public JsonResult GetUser(string SearchValue)
        //{
        //    if (SearchValue != null) Console.WriteLine(SearchValue);
        //    else Console.WriteLine("No string found");
        //    IEnumerable<User> userlist = this.service.GetAll(SearchValue,Convert.ToInt32(Session["CompanyID"]));
        //    //IEnumerable<User> userlist = this.service.GetAll(name, 1);
        //    //IEnumerable<User> userlist = this.service.GetCompanyUsers(Convert.ToInt32(Session["CompanyID"]));
        //    Response.Write("Search string is : " + SearchValue);
        //    /*
        //    var enumerator = userlist.GetEnumerator();
        //    List<User> Results = new List<AllieEntity.User>();
        //    foreach(User i in userlist)
        //    {

        //        if (i.UserName.Contains(name)) {
        //            if (i == null) Response.Write("Username not found");
        //            else Results.Add(i);
        //        } 
        //    }
        //    userlist = Results;
        //    */
        //    //return PartialView("SearchResults", userlist);
        //    return Json(userlist, JsonRequestBehavior.AllowGet);
        //}


    }
}