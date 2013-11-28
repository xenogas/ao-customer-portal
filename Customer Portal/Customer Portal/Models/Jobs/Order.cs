using Customer_Portal.Models.Jobs.Envelopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models.Jobs
{
	public class Order
	{
		public int Id { get; set; }
		public OrderType Type { get; set; }
		public Envelope Envelope { get; set; }
		public DateTime RunDate { get; set; }
	}
}