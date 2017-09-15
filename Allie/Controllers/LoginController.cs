using Allie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AllieService;
using AllieEntity;

namespace Allie.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        
        [HttpGet]
        public ActionResult Index()
        {
            Response.Write("In index");
            return View();
        }
        

        [HttpPost]
        public ActionResult Index(LogIn log)
        {
            Response.Write("In index model");
            
            if (LogIn.Validate(log))
            {
                User user = ServiceFactory.GetUserServices().Get(log.UserMail);
                if (user == null) { ViewBag.ErrorMessage = "Username not found"; }
                else
                {
                    if (user.UserName == log.UserMail)
                    //if (log.UserMail == "1")
                    {
                        if (user.Password == log.Password)
                        //if (log.Password == "1")
                        {
                            Session["LoggedIn"] = true;
                            Session["UserId"] = user.UserId;
                            Session["UserName"] = user.UserName;
                            Session["CompanyId"] = user.CompanyId;
                            return RedirectToAction("Index", "Company");
                        }
                        ViewBag.ErrorMessage = "Incorrect username or password";
                    }
                }
                
                return View();
            }
            
            ViewBag.ErrorMessage = "Incorrect username or password";
            
            return View();

            //Console.WriteLine("User/Pass not validated");
            //return RedirectToAction("Index");
            //return RedirectToAction("Index", "Login", new { ErrorMessage = "Incorrect username or password" });
            //Response.Write("saal");
            //return RedirectToAction("Index");
        }

    }
}