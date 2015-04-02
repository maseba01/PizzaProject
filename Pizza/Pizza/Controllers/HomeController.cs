using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pizza.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestException()
        {
            try
            {
                throw new Exception("Behold! A groovy inner exception.");
            }
            catch (Exception e)
            {
                throw new Exception("Look, I caught and wrapped an exception!", e);
            }
        }

    }
}