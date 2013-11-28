using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Customer_Portal.Models.Users;
using Customer_Portal.Models.Common;

namespace Customer_Portal.Models.Jobs.Inserts
{
	public class ShippedInsert
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Sender { get; set; }
		public Address SenderAddress { get; set; }
		public DateTime ExpectedReceiptDate { get; set; }
		public DateTime DateReceived { get; set; }
		public ExcessOption ExcessHandling { get; set; }
		public DateTime ExcessHoldDate { get; set; }
		public Address ExcessReturnAddress { get; set; }
		public ShortageOption ShortageHandling { get; set; }
	}
}