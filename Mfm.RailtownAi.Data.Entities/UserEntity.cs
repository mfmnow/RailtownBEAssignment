using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mfm.RailtownAi.Data.Entities
{
    public class UserEntity
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        [NotMapped]
        public Address Address { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [NotMapped]
        [JsonProperty("company")]
        public Company Company { get; set; }
    }
}
