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

		public ActionResult Search(String name)
		{
			var message = Server.HtmlEncode(name);
			return Content(message+ "   testing Content");

		}
    }
}