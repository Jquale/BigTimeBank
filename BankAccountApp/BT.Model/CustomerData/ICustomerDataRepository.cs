using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData
{
	public interface ICustomerDataRepository : IBaseRepository<Customer>
	{
		void InsertCustomer(Customer customer);
	}
}
