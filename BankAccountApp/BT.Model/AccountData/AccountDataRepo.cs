﻿using BT.Model.CustomerData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT.Model.AccountData
{
	internal class AccountDataRepo : IAccountDataRepository
	{
		public ISampleItem GetSampleItem()
		{
			return new SampleItem(new SampleItemDto() { Id = 0 });



		}
	}
}
