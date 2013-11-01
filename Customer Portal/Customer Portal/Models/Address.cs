using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models
{
	public class Address
	{
		public int Id { get; set; }
		public AddressType Type { get; set; }
		public string Line1 { get; set; }
		public string Line2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public short Zip { get; set; }
	}
}