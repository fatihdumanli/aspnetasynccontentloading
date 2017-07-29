using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsyncContentLoading.Controllers
{
    public class HomeController : Controller
    {



    
        public ActionResult SyncPage()
        {
            var images = new List<string>()
            {
                "http://fatihdumanli.com/fatih/bosphorus/1.jpg",
                "http://fatihdumanli.com/fatih/bosphorus/1.jpg",
                "http://fatihdumanli.com/fatih/bosphorus/3.jpg",
                "http://fatihdumanli.com/fatih/bosphorus/4.jpg",
            };

            return View(images);
        }







        public ActionResult GetImageData()
        {
            var images = new List<string>()
            {
                "http://fatihdumanli.com/fatih/bosphorus/1.jpg",
                "http://fatihdumanli.com/fatih/bosphorus/1.jpg",
                "http://fatihdumanli.com/fatih/bosphorus/3.jpg",
                "http://fatihdumanli.com/fatih/bosphorus/4.jpg",
            };

            return Json(images, JsonRequestBehavior.AllowGet);
        }






        public ActionResult AsyncPage()
        {  
            return View();
        }





    }
}