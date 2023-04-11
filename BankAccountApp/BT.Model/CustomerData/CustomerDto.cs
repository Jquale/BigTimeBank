using BT.Model.AddressData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData
{
	public class CustomerDto : ICustomerRecord
	{
		public string FirstName { get; set; }
		public int ID { get; set; }	
		public string LastName { get; set; }
		public Address Address { get; set; }
		public string CompanyName { get; set; }
	}
}
