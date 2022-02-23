using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Web_Project.Controllers
{
    public class OrderController : Controller
    {


        public ActionResult Index()
        {
            return View();
           
        }

        public ActionResult Add_Order()
        {
            return View();
        
        }


    }
}