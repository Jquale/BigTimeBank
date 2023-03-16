using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.AddressData
{
	public interface IAddressRecord
	{
		 string Street { get; set; }
		 string City { get; set; }
		 string State { get; set; }
		 int Zip { get; set; }

	}
	public  interface IAddress:IAddressRecord
	{
		//string AddressBlock(Address address);
	}

	
}
