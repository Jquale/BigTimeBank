using System;
using System.Collections.Generic;
using System.Text;

using Dapper;
using System.Linq;

namespace BankAccountApp.Database
{
	public class DatabaseBootstrap : IDatabaseBootstrap
	{
		private readonly DatabaseConfig databaseConfig;


		public void Setup()
		{
			//using (var conection = new SqliteConnection("bt.db"))
			//{
			//	conection.Open();
			//	var table = conection.Query<string>("SELECT name FROM sqllite_master WHERE type='table' AND name='Customer'");
			//	var tableName = table.FirstOrDefault();

			//	if (!string.IsNullOrEmpty(tableName) && tableName == "Customer")
			//	{
			//		return;
			//	}
			//	// No specifying primary key thus we will get a 'rowid' identity column that is autoincremented	
			//	conection.Execute("CREATE Table Customer (" +
			//	"LastName VARCHAR(100) NOT NULL)" +
			//	"CompanyName VARCHAR(100) NOT NULL)");


			//}


		}

	}


}
