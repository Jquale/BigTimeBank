using BT.Model.AddressData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData
{
	public class Customer : ICustomer
	{
		private CustomerDto _customer;

		public Customer()
		{

		}

		public string FirstName
		{
			get { return _customer.FirstName; }
			set { _customer.FirstName = value; }
		}

		public string LastName
		{
			get { return _customer.LastName; }
			set { _customer.LastName = value; }

		}
		public Address Address
		{
			get { return _customer.Address; }
			set { _customer.Address = value; }
		}

		public string CompanyName 
		{
			get { return _customer.CompanyName; }
			set { _customer.CompanyName = value; }
		}

	}										

}
