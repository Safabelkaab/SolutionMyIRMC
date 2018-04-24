using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolutionMyIRMC.MVC.Controllers
{
    public class HomeuserController : Controller
    {
        // GET: Homeuser
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}