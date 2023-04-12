using BT.Model.CustomerData;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BT.Model.AddressData
{
	public class AddressRepository
	{
		private IDbConnection database;

		public AddressRepository(string cString) 
		{
			database = new SqlConnection(cString);
		}

		public Address GetAddressById(int id)
		{
			var query = $"SELECT * FROM Address a WHERE a.ID= {id}";
			return database.Query<Address>(query).FirstOrDefault();
		
		}

		public Address SaveAddress(Address address)
		{
			try
			{
				var query = $"INSERT INTO dbo.Address " +
					$"([Street], [City], [State], [Zip])" +
					$"VALUES('{address.Street}','{address.City}','{address.State}', '{address.Zip}')" +
					$"SELECT CAST(SCOPE_IDENTITY() AS INT)";

				var id = database.Query<int>(query, address).FirstOrDefault();
				address.AddressID =id;
			}
			catch (SqlException ex)
			{

			}

			return address;
		}
	}
}
