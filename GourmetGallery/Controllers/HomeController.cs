using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GourmetGallery.Models;

namespace GourmetGallery.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			//To See what values the route table has
			var controller = RouteData.Values["controller"];
			var action = RouteData.Values["action"];
			var id = RouteData.Values["id"];

			var message = String.Format("{0}::{1} {2}", controller, action, id);

			ViewBag.Message = message;

			return View();
		}

		public ActionResult About()
		{
			//ViewBag.Message = "Your application description page.";
			//ViewBag.Location = "Houston,Texas,USA";

			var model = new AboutModel();
			model.Name = "Vishal Pallerla";
			model.Location = "Houston,Texas";

			return View(model);
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}