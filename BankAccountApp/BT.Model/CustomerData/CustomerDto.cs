using BT.Model.AddressData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData
{
	internal class CustomerDto : ICustomerRecord
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Address Address { get; set; }
		public string CompanyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
