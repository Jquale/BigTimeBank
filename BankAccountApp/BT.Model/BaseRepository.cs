using Dapper;

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml;

namespace BT.Model
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class
	{

		public BaseRepository(string table)
		{
			tableName = table;

		}

		public virtual bool Delete<entity>(T ent)
		{
			using (var conn = Connection)
			{
				conn.Open();
				return conn.Execute("DELETE FROM " + tableName + " WHERE Id=@ID") == 0;
			}
		}

		public virtual bool Save<entity>(T ent)
		{
			throw new NotImplementedException();
		}
	}
}
