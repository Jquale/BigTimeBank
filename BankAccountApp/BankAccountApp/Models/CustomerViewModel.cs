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
	public class CustomerViewModel
	{
		//private Customer cust = new Customer();
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string CompanyName { get; set; }
		public string Street { get; set; }
		public string State { get; set; }	
		public string City { get; set; }	
		public int PostalCode { get; set; }	
		public int Zip { get; set; }
		public CustomerViewModel()
		{

		}
		public CustomerViewModel(string firstName, string lastName, string companyName, string street,
			string city, string state, int postalCode, int zip) 
		{
			FirstName = firstName;
			LastName = lastName;	
			CompanyName = companyName;	
			Street = street;	
			City = city;	
			State = state;	
			City = city;
			PostalCode = postalCode;
			Zip = zip;
		}
	}
}