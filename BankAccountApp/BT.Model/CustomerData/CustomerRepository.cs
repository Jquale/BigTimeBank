using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

		public IDbConnection Connection => throw new NotImplementedException();


		//public IDbConnection Connection => throw new NotImplemcustedException();

		public CustomerRepository(DataContext context)
		{
			_context = context;
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

		public async Task<IEnumerable<Customer>> GetCustomers(int id)
		{

			using (var conn = _context.CreateConnection())
			{
				var query = "SELECT * FROM Customers c ORDER BY c.LastName";
				return await conn.QueryAsync<Customer>(query);
			}

		}
		public async Task<Customer> GetCustomerById(int id)
		{

			using (var conn = _context.CreateConnection())
			{
				var query = "SELECT * FROM Customers c WHERE c.Id = id";
				return await conn.QueryFirstOrDefaultAsync<Customer>(query);
			}

		}

		public async Task<Customer> Save(Customer cust)
		{
			var query = $"INSERT INTO Customer (LastName, CompanyName) VALUES({cust.LastName}, {cust.CompanyName}), {cust};";
			using (var conn = _context.CreateConnection())
			{
				return await conn.QueryFirstAsync<Customer>(query);
			}
		}

		public bool Delete<entity>(Customer ent)
		{
			throw new NotImplementedException();
		}

		public bool Save<entity>(Customer ent)
		{
			throw new NotImplementedException();
		}
	}
}
