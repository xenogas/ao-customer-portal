using Customer_Portal.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models.Jobs.Envelopes
{
	public class Envelope
	{
		public int Id { get; set; }
		public PaperType PaperType { get; set; }
		//TODO: Determine what this 'special envelope' setting is.  Is it a bool, a reference to another envelope type, something else?
		//public bool SpecialEnvelope { get; set; }
		public string LayoutInstructions { get; set; }
		public ExcessOption ExcessHandling { get; set; }
		public Address ExcessReturnAddress { get; set; }
		public ShortageOption ShortageHandling { get; set; }
		public DateTime DateReceived { get; set; }
	}
}