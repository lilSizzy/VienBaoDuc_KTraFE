using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VienBaoDuc_KTraFE.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}
 
        public ActionResult TrangChu()
        {       
            ViewBag.Message = "Your application description page.";
            return View();
        }

    }
}