using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "this is my default action";
        }
        public string Welcome()
        {
            return "this is my welcome action";
        }
    }
}