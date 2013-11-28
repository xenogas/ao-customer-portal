using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models.Jobs.Inserts
{
	public class Insert
	{
		public int Id { get; set; }
		public ShippedInsert ShippedInsert { get; set; }
		public UploadedInsert UploadedInsert { get; set; }
		public DateTime UploadByDate { get; set; }
	}
}