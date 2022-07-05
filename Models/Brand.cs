using Newtonsoft.Json;

namespace PalletizingReworked.Models
{
    public class Brand
    {
        public string Id { get; set; }

        [JsonProperty("Brand")]
        public string brand { get; set; }
    }
}
