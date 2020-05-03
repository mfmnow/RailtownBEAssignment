using Newtonsoft.Json;

namespace Mfm.RailtownAi.Data.Entities
{
    public partial class Geo
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }
}
