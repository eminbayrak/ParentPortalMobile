using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ParPorApp.Models
{
    public class Newsfeed
    {
        public Newsfeed Newsfeeds { get; set; }
        [JsonProperty("Description")] public string Description { get; set; }

        [JsonProperty("DistrictId")] public string DistrictId { get; set; }

        [JsonProperty("Id")] public long Id { get; set; }

        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("UserId")] public string UserId { get; set; }

        [JsonProperty("ImageUrl")] public string ImageUrl { get; set; }

        [JsonProperty("GameIcon")] public string GameIcon { get; set; }

        [JsonProperty("PostDate")] public string PostDate { get; set; }

        [JsonProperty("EventDate")] public string EventDate { get; set; }

        [JsonProperty("HomeTeamLogo")] public string HomeTeamLogo { get; set; }

        [JsonProperty("AwayTeamLogo")] public string AwayTeamLogo { get; set; }

        [JsonProperty("HomeTeamName")] public string HomeTeamName { get; set; }

        [JsonProperty("AwayTeamName")] public string AwayTeamName { get; set; }

        [JsonProperty("Location")] public string Location { get; set; }

        [JsonProperty("Weather")] public string Weather { get; set; }

        [JsonProperty("VS")] public string VS { get; set; }

        [JsonProperty("Note")] public string Note { get; set; }

        public string LocationHint { get; set; } = string.Empty;

        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

