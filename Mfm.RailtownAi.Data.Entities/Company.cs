using Newtonsoft.Json;

namespace Mfm.RailtownAi.Data.Entities
{
    public partial class Company
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("catchPhrase")]
        public string CatchPhrase { get; set; }

        [JsonProperty("bs")]
        public string Bs { get; set; }
    }
}
