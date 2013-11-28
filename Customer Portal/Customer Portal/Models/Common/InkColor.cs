using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models.Common
{
	public class InkColor
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string RGB { get; set; }
		public string CMYK { get; set; }
		public string Description { get; set; }
	}
}