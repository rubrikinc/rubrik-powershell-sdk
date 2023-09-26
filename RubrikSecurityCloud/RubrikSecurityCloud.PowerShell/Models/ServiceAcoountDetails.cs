using System;
using Newtonsoft.Json;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Models
{
    public class ServiceAcoountDetails
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("access_token_uri")]
        public string AccessTokenUri { get; set; }
    }
}

