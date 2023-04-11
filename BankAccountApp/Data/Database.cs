using Microsoft.Data.SqlClient;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Dapper;

namespace BankAccountApp.Database
{
	public class Database //: IDatabase
	{
		//private readonly DatabaseConfig _config;

		public SqlConnection OpenConnection()
		{
			string connStr = GetConnectionString(); 
			using (var conn = new  SqlConnection(connStr))
			{
				try
				{
					conn.Open();
				}
				catch(SqlException ex) 
				{
					Console.WriteLine(ex.ErrorCode)	;

				}


				return conn;


				//var table = conn.Query<string>("SELECT name FROM sqllite_master WHERE type='table' AND name='Customer'");
				//var tableName = table.FirstOrDefault();

				//if (!string.IsNullOrEmpty(tableName) && tableName == "Customer")
				//{
				//	return ;
				//}

				//conn.Execute("CREATE Table Customer (" +
				//	"ID INT IDENTITY" +
				//	"LastName VARCHAR(100) NOT NULL)" +
				//	"CompanyName VARCHAR(100) NOT NULL)");

			}

		}

		private string GetConnectionString()
		{
		    //conn.ConnectionString = "Data Source=DRAGO; Initial Catalog=BTBank; User id=jesse; Password=paZZ4sql;";

			return "Data Source=DRAGO; Initial Catalog=BTBank; Integrated Security=true;";
 
		}

		public static void Setup()
		{
		}


		public static void Update() { }
		public static void Delete() { }
		public static void DeleteAll() { }
		public static void UpdateAll() { }

		public void Getstuff()
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

		public void GetCustomers()
		{
			throw new NotImplementedException();
		}
	}
}
