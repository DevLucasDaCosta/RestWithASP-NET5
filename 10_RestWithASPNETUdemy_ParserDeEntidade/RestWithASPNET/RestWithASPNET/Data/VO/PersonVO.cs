﻿using System.Text.Json.Serialization;

namespace RestWithASPNET.Data.VO
{
    public class PersonVO
    {
        [JsonPropertyName("code")]
        public long Id { get; set; }
        [JsonPropertyName("name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        [JsonIgnore]
        public string Address { get; set; }
        [JsonPropertyName("Gender")]
        public string Gender { get; set; }

    }
}
