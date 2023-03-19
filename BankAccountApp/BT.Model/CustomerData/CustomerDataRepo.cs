using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using BankAccountApp.Database;

namespace BT.Model.CustomerData
{
	public class CustomerDataRepo : ICustomerDataRepository
	{
		public CustomerDataRepo()
		{

		}

		public IDbConnection Connection => throw new NotImplementedException();

		public bool Delete<entity>(Customer ent)
		{
			throw new NotImplementedException();
		}

		public void DeleteCustomer(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Customer> GetCustomers(int id)
		{
			Database.GetCustomers();
			throw new NotImplementedException();
		}

		public bool Save<entity>()
		{
			throw new NotImplementedException();
		}

		void ICustomerDataRepository.InsertCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}
	}
}
