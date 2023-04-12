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
using BankAccountApp.Database;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using System.Data.Common;
using System.Linq.Expressions;

namespace BT.Model.CustomerData
{
	public class CustomerRepository : ICustomerRepository
	{
		private IDbConnection database;

		public CustomerRepository(string cString)
		{
			database = new SqlConnection(cString);
		}
		public List<Customer> GetList()
		{
			var query = "SELECT * FROM Customer c ORDER BY c.LastName";
			return database.Query<Customer>(query).ToList();

		}
		public Customer GetCustomerById(int id)
		{

			var query = "SELECT * FROM Customer c WHERE c.Id = id";
			return database.Query<Customer>(query).FirstOrDefault();

		}
		public Customer GetNewCustomer()
		{
			return new Customer();
		}

		public Customer SaveCustomer(Customer customer)
		{
			try
			{
				var query = $"INSERT INTO BTBank.dbo.Customer " +
					$" ([FirstName], [LastName], [CompanyName]) " +
					$"VALUES('{customer.FirstName}', '{customer.LastName}','{customer.CompanyName}')" +
					$"SELECT CAST(SCOPE_IDENTITY() AS INT)";

				var id = database.Query<int>(query, customer).FirstOrDefault();
				customer.ID = id;

			}
			catch(SqlException ex)
			{

			}

			return customer;	
		}
		public bool Delete<entity>(Customer ent)
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

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}
