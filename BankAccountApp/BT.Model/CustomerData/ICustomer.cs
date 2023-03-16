using BT.Model.AddressData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData
{
	public interface ICustomerRecord
	{

	}
	internal interface ICustomer
	{
		string FirstName { get; set; }
		string LastName { get; set; }	
		Address Address { get; set; }	
	}
}
