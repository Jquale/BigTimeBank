using System;

namespace BTBankRest.Entity
{
	public class Customer
	{
		public Customer()
		{ }

        public string CompanyName { get;set; }
		public string FirstName { get;set; }
        public string LastName { get;set; }
		public string AddressCity { get;set; }
		public string AddressState { get;set; }
		public string AddressStreet { get;set; }
		public string AddressZip { get;set; }

	}
}

