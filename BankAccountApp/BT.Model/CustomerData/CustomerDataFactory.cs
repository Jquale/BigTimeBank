using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.CustomerData
{
	public static class CustomerDataFactory
	{
		public static ICustomerDataRepository Create()
		{
			return new CustomerDataRepo();
		}
	}
}
