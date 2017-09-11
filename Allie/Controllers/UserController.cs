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
    }
}