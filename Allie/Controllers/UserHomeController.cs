using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Allie.Controllers
{
    /*
     * The items in the lists need to redirect to different pages... 
     * If anchor cannot be used inside option tab, the redirection will have to be performed manually
     * */
    public class UserHomeController : Controller
    {
        // GET: UserHome
        public ActionResult Index()
        {
            return View();
        }
    }
}