using Customer_Portal.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models.Jobs.Envelopes
{
	public class MessageDefinition
	{
		public int Id { get; set; }
		public EnvelopeArea Area { get; set; }
		public Font Font { get; set; }
		public InkColor FontColor { get; set; }
		//TODO: Figure out how we're adding the graphic
		//prop image graphic
		public string Text { get; set; }
	}
}