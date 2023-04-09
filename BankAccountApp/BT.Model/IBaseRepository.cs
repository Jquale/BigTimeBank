
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BT.Model
{
	public interface IBaseRepository<T> where T : class
	{
		bool Delete<entity>(T ent);
		bool Save<entity>(T ent);
		
		IDbConnection Connection { get; }
	}
}
