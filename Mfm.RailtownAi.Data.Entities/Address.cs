using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mfm.RailtownAi.Data.Entities
{
    public partial class Address
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("suite")]
        public string Suite { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("geo")]
        [NotMapped]
        public Geo Geo { get; set; }
    }
}
