using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.AddressData
{
	public class AddressDto : IAddressRecord
	{
		public int AddressID { get; set; }
		public string Street { get; set; }
		public string City { get; set; } 
		public string State { get; set; }
		public int Zip { get; set; }
	}
} 