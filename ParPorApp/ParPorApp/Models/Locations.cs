using System;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ParPorApp.Models
{
    public class Locations
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }


        [Microsoft.WindowsAzure.MobileServices.Version]
        public string Version { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        public string LocationHint { get; set; } = string.Empty;

        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;


        [JsonIgnore]
        public Uri ImageUri
        {
            get { return new System.Uri(Image); }
        }

        public double Latitude { get; set; } = 0;
        public double Longitude { get; set; } = 0;
        public string PhoneNumber { get; set; } = string.Empty;
        public string LocationCode { get; set; } = string.Empty;
    }


}

