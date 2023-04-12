using BT.Model.CustomerData;
using System;
using System.Web.Configuration;
using System.Web.Mvc;
using BankAccountApp.Models;
using BT.Model.AddressData;
using System.Collections.Generic;
using System.Linq;

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
			return PartialView($"Page.CustomerList");
		}

		public bool AddCustomer(CustomerViewModel cvm)
		{
			Customer customer = new Customer(0, cvm.FirstName, cvm.LastName, cvm.CompanyName);
			Address address = new Address(cvm.Street, cvm.City, cvm.State,  cvm.Zip);
			var configuation = WebConfigurationManager.OpenWebConfiguration("~");
			var connString = System.Configuration.ConfigurationManager.ConnectionStrings["BTBankConnection"].ConnectionString;
			var addrRepo = new AddressRepository(connString);
				
			var addressRepo = addrRepo.SaveAddress(address);
			var custRepo = new CustomerRepository(connString);

			var cust = custRepo.SaveCustomer(customer);

			return cust.ID != 0;
		}
		
		public List<Customer> CustomerList()
		{
			var connString = System.Configuration.ConfigurationManager.ConnectionStrings["BTBankConnection"].ConnectionString;
			var custRepo = new CustomerRepository(connString);
			return custRepo.GetList();	
		}
	}
}