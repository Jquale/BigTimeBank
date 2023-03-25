using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using Microsoft.Data.Sqlite;

namespace BT.Model.Util
{
	public class DataContext
	{
		public IDbConnection CreateConnection()
		{
			return new SqliteConnection("Data Source=InMemorySample;Mode=Memory;Cache=Shared");
		}
	}
}
