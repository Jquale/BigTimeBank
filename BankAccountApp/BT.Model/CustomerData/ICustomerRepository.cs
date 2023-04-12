using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BT.Model.CustomerData
{
	public interface ICustomerRepository// : IBaseRepository<Customer>
	{
		Customer GetCustomerById(int id);
		List<Customer> GetList();
		Customer GetNewCustomer();
		Customer Add(Customer customer);
		Customer Update(Customer customer);
		void Delete(int id);
	}
}
