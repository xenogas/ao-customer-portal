using Customer_Portal.Models.Common;
using Customer_Portal.Models.Jobs;
using Customer_Portal.Models.Jobs.Envelopes;
using Customer_Portal.Models.Jobs.Inserts;
using Customer_Portal.Models.Jobs.Statements;
using Customer_Portal.Models.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models
{
	public class AOCustomerDb : DbContext
	{
		// Default constructor telling the DB Context to use the Default Connection
		// (specified in the web.config file)
		public AOCustomerDb() : base("DefaultConnection")
		{
		}

		// Common
		public DbSet<Address> Addresses { get; set; }
		public DbSet<AddressType> AddressTypes { get; set; }
		public DbSet<InkColor> InkColors { get; set; }
		public DbSet<Font> Fonts { get; set; }
		public DbSet<PaperType> PaperTypes { get; set; }
		public DbSet<Printer> Printers { get; set; }
		public DbSet<PaperColor> PaperColors { get; set; }

		// User Information
		public DbSet<PhoneNumber> PhoneNumbers { get; set; }
		public DbSet<PhoneType> PhoneTypes { get; set; }

		// Orders
		public DbSet<OrderType> OrderTypes { get; set; }
		public DbSet<Order> Orders { get; set; }
		//	get {
		//		DbSet<Order> orders = 
		//			.Select(r => new Order
		//			{
		//				Id = r.Id,
		//				Envelope = r.Envelope,
		//				RunDate = r.RunDate,
		//				Type = this.OrderTypes
		//					.FirstOrDefault(t => t.Id == Convert.ToInt32(r.Type))
		//			}) as DbSet<Order>;

		//		return orders;
		//	}
		//	set
		//	{
		//		//this.Orders.
		//	}
		//}

		// Envelopes

		// Inserts

		// Statements
		public DbSet<StatementAction> StatementActions { get; set; }
	}
}