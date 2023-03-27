using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankAccountApp.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Page(String id, string subView = "")
		{
			return PartialView($"Page.{id}");
		}
		
		public ActionResult NewAccount()
		{
			return PartialView($"Page.AddCustomer");
		}

		public ActionResult GetAll() { return View(); }

		//public ActionResult Menu(String id)
		//{

		//	return PartialView("..\\Shared\\_Menubar");

		//}
	}
}