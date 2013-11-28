using Customer_Portal.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models.Jobs.Inserts
{
	public class UploadedInsert
	{
		public int Id { get; set; }
		public string Name { get; set; }
		//TODO: Determine whether this needs to be just a single file, or a file name and separate path
		public string InsertFile { get; set; }
		public InkColor InkColor { get; set; }
		public PaperType PaperType { get; set; }
		public PaperColor PaperColor { get; set; }
		public Printer Printer { get; set; }
	}
}