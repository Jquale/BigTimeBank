using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using Microsoft.IdentityModel.Protocols;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BT.Model.CustomerData
{
	public class CustomerRepository : ICustomerRepository
	{
		private IDbConnection database;

		//private string connString = ConfigurationManager<string>.ConnectionStrings["btbConnStr"];
			public CustomerRepository()
		{

		}
	
		public CustomerRepository(string cString)
		{

		}

		public string AddCustomer(Customer cust)
		{
			var query = "INSERT INTO Customers (FirstName, LastName, Email, Company, Title) " +
				"VALUES(John, doe, selfEmp, Pres)" +
				"SELECT CAST(SCOPE_IDENTITY () as INT)";
			var id = database.Query<int>(query, cust).SingleOrDefault();
			string retVal = string.Empty;
			cust.ID = id;

			return retVal;
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
			return  database.Query<Customer>(query).ToList();

		}
		public Customer GetCustomerById(int id)
		{

			var query = "SELECT * FROM Customers c WHERE c.Id = id";
			return database.Query<Customer>(query).FirstOrDefault();

		}

		public Customer SaveCustomer(Customer cust)
		{
			var query = $"INSERT INTO Customer (LastName, CompanyName) VALUES({cust.LastName}, {cust.CompanyName}), {cust};";
			var thing = database.Query<Customer>(query).FirstOrDefault();
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
