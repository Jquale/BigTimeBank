using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BankAccountApp.Database
{
	public class DatabaseBootstrap : IDatabaseBootstrap
	{
		private readonly DatabaseConfig _config;
		
		public DatabaseBootstrap(DatabaseConfig config) 
		{
			_config = config;
		}
		public void Setup()
		{
			using(var conection = new SqliteConnection(_config.Name))
			{
				conection.Open();
				var table = conection.Query<string>("SELECT name FROM sqllite_master WHERE type='table' AND name='Customer'");
				var tableName = table.FirstOrDefault(); 

				if(!string.IsNullOrEmpty(tableName) && tableName == "Customer") 
				{
					return;
				}

				conection.Execute("CREATE Table Customer (" +
					"LastName VARCHAR(100) NOT NULL)" +
					"CompanyName VARCHAR(100) NOT NULL)");

			}
			//using var connection = new SqliteConnection(DatabaseConfig.Name);
		}
	}
}