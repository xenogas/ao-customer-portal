using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models.Jobs.Statements
{
	public class Graphic
	{
		public int Id { get; set; }
		//TODO: Determine whether we need to store just the file or the file name and path
		public string File { get; set; }
		//public string FileName { get; set; }
		//public string FilePath { get; set; }
		public DateTime UploadByDate { get; set; }
		public GraphicPosition Position { get; set; }
	}
}