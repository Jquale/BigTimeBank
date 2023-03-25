using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BT.Model;
using BT.Model.AccountData;
using BT.Model.CustomerData;

namespace BankAccountApp.Models
{
	public class CustomerModel
	{
		private Customer cust = new Customer();
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }	
		public string PostalCode { get; set; }	
		
		public CustomerModel(string id) 
		{

		}
	}
}