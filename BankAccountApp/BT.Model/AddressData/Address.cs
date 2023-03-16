using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.AddressData
{
	internal class Address : IAddress
	{
		private AddressDto _record;

		public Address() { }

		Address(AddressDto record = null) {
			if(record==null){ record = new AddressDto(); }
			_record = record;
		}

		Address(string street, string city, string state, int zip )
		{
			_record.Street = street;
			_record.City = city;
			_record.State = state;	
			_record.Zip = zip;	
		}

		public string Street
		{
			get { return _record.Street; }
		    set { _record.Street = value; }
	    }
							 
		public string City
		{
			get { return _record.City; }
			set { _record.City = value; }
		}

		public string State 
		{
			get { return _record.State; }
			set { _record.State = value; }
		}

		public int Zip
		{
			get { return _record.Zip; }
			set { _record.Zip = value; }
		}

		public string AddressBlock(Address address)
		{
			throw new NotImplementedException();
		}
	}
}
