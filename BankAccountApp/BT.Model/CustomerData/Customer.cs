using BT.Model.AddressData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData
{
	public class Customer : ICustomer
	{
		private CustomerDto _customer = new CustomerDto();

		public Customer() { }

		public Customer(string fName) { _customer.FirstName = fName; }

		public Customer(int id, string fName, string lName, string cName)
		{
			_customer.ID = id;
			_customer.LastName = lName;
			_customer.FirstName = cName;	
			_customer.CompanyName = cName;
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

		public string FirstName
		{
			get { return _customer.FirstName; }
			set { _customer.FirstName = value; }
		}

		public int ID
		{
			get { return _customer.ID; }
			set { ID = value; }
		}
		public string LastName
		{
			get { return _customer.LastName; }
			set { _customer.LastName = value; }

		}

		int ICustomerRecord.ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}										

}
