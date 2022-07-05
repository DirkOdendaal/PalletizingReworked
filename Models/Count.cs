using Newtonsoft.Json;

namespace PalletizingReworked.Models
{
    public class Count
    {
        public string Id { get; set; }

        [JsonProperty("Count/Size")]
        public string count { get; set; }

        [JsonProperty("Size Class")]
        public string clas { get; set; }

        [JsonProperty("Commodity")]
        public string commod { get; set; }
    }
}
