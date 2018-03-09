using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ParPorApp.Models
{
    class Event
    {
	    [JsonProperty("Description")]
		public string Description { get; set; }

	    [JsonProperty("EndDateTime")]
		public string EndDateTime { get; set; }

	    [JsonProperty("GroupId")]
		public string GroupId { get; set; }

	    [JsonProperty("Id")]
		public int Id { get; set; }

	    [JsonProperty("LocationId")]
		public string LocationId { get; set; }

	    [JsonProperty("StartDateTime")]
		public string StartDateTime { get; set; }

	    [JsonProperty("Name")]
		public string Name { get; set; }
	}
}
