using BT.Model.AddressData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData{
	public interface ICustomerRecord
	{
		string CompanyName { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }	

	}
	public interface ICustomer:ICustomerRecord
	{
		Address Address { get; set; }	
	}
}
