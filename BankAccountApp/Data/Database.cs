using Dapper;
using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp.Database
{
	public class Database //: IDatabase
	{
		//private readonly DatabaseConfig _config;

		public static void Setup()
		{
			using (var conection = new SqliteConnection("bt.db"))
			{
				conection.Open();
				var table = conection.Query<string>("SELECT name FROM sqllite_master WHERE type='table' AND name='Customer'");
				var tableName = table.FirstOrDefault();

				if (!string.IsNullOrEmpty(tableName) && tableName == "Customer")
				{
					return;
				}

				conection.Execute("CREATE Table Customer (" +
					"LastName VARCHAR(100) NOT NULL)" +
					"CompanyName VARCHAR(100) NOT NULL)");

			}
		}


		public static void Update() { }
		public static void Delete() { }
		public static void DeleteAll() { }
		public static void UpdateAll() { }

		public static void Getstuff()
		{
			Setup(); //public static IEnumerable<sqlite3_value> Get(SqliteConnection conn) //{
					 //	SqliteDataReader reader;
					 //	SqliteCommand cmd;
					 //	cmd = conn.CreateCommand();
					 //	cmd.CommandText = "SELECT * FROM Customer";
					 //	return cmd.ExecuteReader;

			//}

			/////////////////////////////////////
			// public async Task<List<T>> Get()
			// { 


			//		await return;
			// }

		}

		public static void GetCustomers()
		{
			throw new NotImplementedException();
		}
	}
}
