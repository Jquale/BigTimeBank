using BT.Model.AddressData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData
{
	internal class Customer : ICustomer
	{
		private CustomerDto _customer;

		public Customer(CustomerDto customer = null)
		{
			if (customer == null) { customer = new CustomerDto(); }

			_customer = customer;
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

		public string CompanyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public bool Delete()
		{
			throw new NotImplementedException();
		}

		public bool Save()
		{
			throw new NotImplementedException();
		}
	}										

}
