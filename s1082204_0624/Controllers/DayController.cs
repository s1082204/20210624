using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace s1082204_0624.Controllers
{
    public class DayController : Controller
    {
        // GET: Day
        public ActionResult Index(float? weight)
        {
            var result = "";

            

            if (weight.HasValue)
            {
                result = "星期"+ (weight);  
            }
            ViewBag.result = result;

            return View();
        }
    }
}