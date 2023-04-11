using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BT.Model.CustomerData
{
	public interface ICustomerRepository// : IBaseRepository<Customer>
	{
		Customer Get(int id);
		List<Customer> GetAll();
		Customer Add(Customer customer);
		Customer Update(Customer customer);
		void Delete(int id);
	}
}
