using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ParPorApp.Models
{
    
	public class User
    {
	    [JsonProperty("FirstName")]
		public string FirstName { get; set; }
	    [JsonProperty("LastName")]
		public string LastName { get; set; }
	    [JsonProperty("Children")]
		public string Children { get; set; }
	    [JsonProperty("Email")]
		public string Email { get; set; }
	    [JsonProperty("Image")]
		public string Image { get; set; }
    }
    [JsonObject]
    public class UserAccount
    {
        public string UserInfoViewModel { get; set; }
    }
}
