using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GourmetGallery.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Index()
        {
            return View();
        }

		//[HttpPost]
		//Using HttpPost request and going to http://localhost:82/GourmetGallery/GourmetGallery/Cuisine/Italian
		//throws an error since by default browser sends a get request when we type something in address and click enter

			[HttpGet]
			//This will run since MVC framework finds a Get method to invoke
		public ActionResult Search(String name)
		{
			var message = Server.HtmlEncode(name);
			return Content(message+ "   testing Content");
			//return RedirectPermanent("https://www.google.com"); // returns a 301 status code
			//return RedirectToAction("Index", "Home"); // This is a temporary redirect
			//return RedirectToRoute("Default", new {controller = "Home", action = "About" });

			//return File(Server.MapPath("~/Content/site.css"), "text/css"); 
			//We will give virtual path and Server.MapPath will convert it to an actual physical path the 
			//OS will understand

			//return Json(new { Message = message, Name = "Vishal" }, JsonRequestBehavior.AllowGet);

		}
    }
}