using BT.Model.AccountData;
using BT.Model.CustomerData;
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

		public ActionResult Customer()
		{
			return PartialView($"Page.Customer");
		}
		
		//public bool AddCustomer(string fName) 
		//{
		//	Customer customer = new Customer(fName);
		//	var repo = new CustomerRepository();
		//    return	repo.Add(customer).ID != null;



		//}


		//public void SaveCustomer(string fName, string lName, string cName)
		public void SaveCustomer(Dictionary<string, string> fName)
		{
			var repo = new CustomerRepository();

		}
		

	

}
}