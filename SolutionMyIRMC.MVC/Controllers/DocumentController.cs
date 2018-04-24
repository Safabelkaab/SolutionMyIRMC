using SolutionMyIRMC.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolutionMyIRMC.MVC.Controllers
{
    public class DocumentController : Controller
    {
        private DocRestfulClient clientrest = new DocRestfulClient(); 
        // GET: Document
        
        public ActionResult Index()
        {
            ViewBag.Result1 = clientrest.hello().Result;
            return View();
        }
        [Route("WelcomeYou/{name}/{numTimes:int}")]
        public string WelcomeYou(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
        public ActionResult Liststage()
        {
            return View();
        }
    }
}