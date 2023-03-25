using System;
using BT.Model.AccountData;
using System.Linq;
using System.Web.Mvc;

namespace BankAccountApp.Controllers
{
	public class CustomerController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult GetAll()
		{
			var custList = AccountDataFactory.GetCustomer(-1).ToList();

			return PartialView("Page.CustomerList", custList);

		}

		protected override void ExecuteCore()
		{
			throw new NotImplementedException();
		}
	}
}