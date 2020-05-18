using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetWebAPI.Controllers
{
    public class PersonellerController : Controller
    {
        // GET: HelpPage/Personeller
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TumPersoneller()
        {
            return View();
        }

        public ActionResult PersonelGetir()
        {
            return View();
        }
    }
}