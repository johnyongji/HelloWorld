using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
            //return "This is index method";
        }

        // GET: HelloWorld
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
            //return "This is welcome method";
        }

        // GET: HelloWorld
        //public string Index()
        //{
        //    // return View();
        //    return "This is index method";
        //}

        //// GET: HelloWorld
        //public string Welcome(string name, int ID= 1)
        //{
        //    //            return View();
        //    //return "This is welcome method";
        //    return HttpUtility.HtmlEncode("Hello" + name + ", ID: " + ID);

        //}
    }
}