using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models
{
	public class AOCustomerDb : DbContext
	{
		public DbSet<Address> Addresses { get; set; }
		public DbSet<AddressType> AddressTypes { get; set; }
	}
}