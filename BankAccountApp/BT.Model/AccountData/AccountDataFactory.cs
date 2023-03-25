using BT.Model.CustomerData;
using BT.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT.Model.AccountData
{
	public static class AccountDataFactory
	{

		public static IAccountDataRepository Create()
		{
			return new AccountDataRepo();
		}
		
		public static List<Customer> GetCustomer(int? id)
		{
			IEnumerable<Customer> customerList;

			switch(id)
			{
				case null:
					return new List<Customer>() { new Customer() };
				case -1:
					customerList = (IEnumerable<Customer>)new CustomerRepository(new DataContext()).GetCustomers((int)id);
					break;
				default:
					customerList = (IEnumerable<Customer>)new CustomerRepository(new DataContext()).GetCustomerById((int)id);
					break;
					
			}

			return customerList.ToList();
		}
	}
}
