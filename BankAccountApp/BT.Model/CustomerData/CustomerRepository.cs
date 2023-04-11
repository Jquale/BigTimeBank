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
		private string connectionString;

		public CustomerRepository(string cString)
		{
			connectionString = cString;
		}
		public List<Customer> GetCustomers(int id)
		{
			var query = "SELECT * FROM Customer c ORDER BY c.LastName";
			return database.Query<Customer>(query).ToList();

		}
		public Customer GetCustomerById(int id)
		{

			var query = "SELECT * FROM Customer c WHERE c.Id = id";
			return database.Query<Customer>(query).FirstOrDefault();

		}

		public Customer SaveCustomer(Customer cust)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				try
				{
					using (SqlCommand cmd = new SqlCommand($"INSERT INTO Customer " +
						$" ([FirstName], [LastName], [CompanyName]) " +
						$"VALUES(@FirstName, @LastName, @CompanyName);", conn))
					{
						cmd.Parameters.Add("FirstName", SqlDbType.VarChar).Value = cust.FirstName;
						cmd.Parameters.Add("LastName", SqlDbType.VarChar).Value = cust.FirstName;
						cmd.Parameters.Add("CompanyName", SqlDbType.VarChar).Value = cust.FirstName;
						cmd.ExecuteNonQuery();
					}
				}
				catch(SqlException ex)
				{

				}

				conn.Close();
			}
			return new Customer();	
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
			return	database.Query<Customer>("SELECT * FROM Contacts").ToList();
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
