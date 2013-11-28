using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models.Users
{
    public class CustomerInfo
    {
		public int Id { get; set; }
		public string CompanyName { get; set; }
		//TODO: Primary Contact
		//TODO: Secondary Contact
		public string Timezone { get; set; }
		public Address BillingAddress { get; set; }
		//TODO: Work Hours
		public Address WorkAddress { get; set; }
    }
}