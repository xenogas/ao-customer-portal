namespace Customer_Portal.Migrations
{
	using Customer_Portal.Models.Common;
	using Customer_Portal.Models.Jobs;
	using Customer_Portal.Models.Users;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Customer_Portal.Models.AOCustomerDb>
    {
        public Configuration()
        {
            // Set to false to strictly enforce changes (manually run migrations)
			AutomaticMigrationsEnabled = true;
        }

		//  This method will be called after migrating to the latest version
		//TODO: Finalize the values for all pre-set types
		//NOTE: Look at removing Description from types
        protected override void Seed(Customer_Portal.Models.AOCustomerDb context)
        {
            // Types of physical addresses
			context.AddressTypes.AddOrUpdate( r => r.Type,
				new AddressType { Type = "Home", Description = "Place of residence." },
				new AddressType { Type = "Work", Description = "Place of Employment." }
			);

			// Types of phone numbers
			context.PhoneTypes.AddOrUpdate( r => r.Type,
				new PhoneType { Type = "Home", Description = "Home phone number." },
				new PhoneType { Type = "Work", Description = "Work phone number." },
				new PhoneType { Type = "Cell", Description = "Mobile phone number." }
			);

			// Types of orders
			context.OrderTypes.AddOrUpdate( r => r.TypeName,
				new OrderType { TypeName = "Bill", Description = "a basic bill.  Change this to a correct value" },
				new OrderType { TypeName = "Visa", Description = "a visa bill" }
			);

			// Types / colors of 
			context.InkColors.AddOrUpdate( r => r.Name,
				new InkColor { Name = "Black", RGB = "0,0,0", CMYK = "0,13,49,98" },
				new InkColor { Name = "Green", RGB = "0,255,0", CMYK = "100,0,66,9"}
			);

			// Fonts
			context.Fonts.AddOrUpdate( r => r.Name,
				new Font { Name = "Arial" },
				new Font { Name = "Helvetica" },
				new Font { Name = "Courier New" },
				new Font { Name = "Consolas" },
				new Font { Name = "SansSerrif" }
			);

			// Printers
			context.Printers.AddOrUpdate( r => r.Name,
				new Printer { Name = "Alpha Omega" },
				new Printer { Name = "Outsource Printer 1" },
				new Printer { Name = "Outsource Printer 2" }
			);

			// Paper
			context.PaperColors.AddOrUpdate( r => r.Color,
				new PaperColor { Color = "Black" },
				new PaperColor { Color = "White" },
				new PaperColor { Color = "Red" },
				new PaperColor { Color = "Creme" }
			);

			context.PaperTypes.AddOrUpdate( r => r.Type,
				new PaperType { Type = "Matte" },
				new PaperType { Type = "Semi-Gloss" },
				new PaperType { Type = "Gloss" }
			);

			//SeedEnvelopes(context);
			//SeedInserts(context);
			//SeedStatements(context);
			//SeedCustomers(context);
			SeedJobs(context);
        }

		private void SeedStatements(Models.AOCustomerDb context)
		{
			throw new NotImplementedException();
		}

		private void SeedInserts(Models.AOCustomerDb context)
		{
			throw new NotImplementedException();
		}

		private void SeedEnvelopes(Models.AOCustomerDb context)
		{
			throw new NotImplementedException();
		}

		private void SeedJobs(Models.AOCustomerDb context)
		{
			OrderType bill = context.OrderTypes.FirstOrDefault( t => t.TypeName == "Bill" );
			OrderType visa = context.OrderTypes.FirstOrDefault( t => t.TypeName == "Visa" );

			//NOTE: updating on the Id is a temporary fix to allow a statically generated 
			// grouping.  The system will automatically update Id in the future.
			context.Orders.AddOrUpdate( r => r.Id,
				new Order { Id = 1, Type = bill, RunDate = new DateTime(2013, 12, 15) },
				new Order { Id = 2, Type = bill, RunDate = new DateTime(2013, 11, 30) },
				new Order { Id = 3, Type = visa, RunDate = new DateTime(2013, 12, 14) }
			);
		}

		private void SeedCustomers(Models.AOCustomerDb context)
		{
			throw new NotImplementedException();
		}
    }
}
