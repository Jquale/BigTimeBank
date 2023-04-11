using BT.Model.AccountData;
using BT.Model.CustomerData;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
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

		public ActionResult Customer()
		{
			return PartialView($"Page.Customer");
		}

		public bool AddCustomer(string fName, string lName, string cName)
		{
			Customer customer = new Customer(0, fName, lName, cName);
			var configuation = WebConfigurationManager.OpenWebConfiguration("~");
			var connString = System.Configuration.ConfigurationManager.ConnectionStrings["BTBankConnection"].ConnectionString;
			var repo = new CustomerRepository(connString);


			var cust = repo.SaveCustomer(customer);

			return cust.ID != 0;


		}

	}
}