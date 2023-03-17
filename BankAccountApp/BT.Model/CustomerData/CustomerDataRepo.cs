using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData
{
	public class CustomerDataRepo : ICustomerDataRepository
	{
		//private readonly 
		public void DeleteCustomer(int id)
		{
			throw new NotImplementedException();
		}

		IEnumerable<Customer> ICustomerDataRepository.GetCustomers(int id)
		{
			throw new NotImplementedException();
		}

		void ICustomerDataRepository.InsertCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}
	}
}
