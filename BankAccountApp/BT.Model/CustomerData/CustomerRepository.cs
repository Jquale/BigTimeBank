using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountApp.Database;
using BT.Model.Util;
using Dapper;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace BT.Model.CustomerData
{
	public class CustomerRepository : ICustomerRepository
	{
		private DataContext _context;

		private IDbConnection connection;


		public CustomerRepository(string connectionString = "Data Source=bt.db")
		{
			connection = new SqliteConnection(connectionString);
			
		}

		//public bool Delete<custity>(Customer cust)
		//{
		//	using (var conn = _context.CreateConnection())
		//	{
		//		var query = $"DELETE FROM Customers ";
		//	}
		//}

		//public void DeleteCustomer(int id)
		//{
		//}

		public List<Customer> GetCustomers(int id)
		{
			var query = "SELECT * FROM Customers c ORDER BY c.LastName";
			return  connection.Query<Customer>(query).ToList();

		}
		public Customer GetCustomerById(int id)
		{

			var query = "SELECT * FROM Customers c WHERE c.Id = id";
			return connection.Query<Customer>(query).FirstOrDefault();

		}

		public Customer SaveCustomer(Customer cust)
		{
			var query = $"INSERT INTO Customer (LastName, CompanyName) VALUES({cust.LastName}, {cust.CompanyName}), {cust};";
			var thing = connection.Query<Customer>(query).FirstOrDefault();
			return thing;
		}

		public bool Delete<entity>(Customer ent)
		{
			throw new NotImplementedException();
		}

		public bool Save<entity>(Customer ent)
		{
			throw new NotImplementedException();
		}

		public Customer Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<Customer> GetAll()
		{
			throw new NotImplementedException();
		}

		public Customer Add(Customer customer)
		{
			throw new NotImplementedException();
		}

		public Customer Update(Customer customer)
		{
			throw new NotImplementedException();
		}

		public Customer Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}
