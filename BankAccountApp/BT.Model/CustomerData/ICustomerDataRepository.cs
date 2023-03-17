using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData
{
	internal interface ICustomerDataRepository
	{
		IEnumerable<Customer> GetCustomers(int id);
		void InsertCustomer(Customer customer);
		void DeleteCustomer(int id);	
	}
}
