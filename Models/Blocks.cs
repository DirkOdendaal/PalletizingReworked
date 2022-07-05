using Newtonsoft.Json;

namespace PalletizingReworked.Models
{
    public class Blocks
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Block Id")]
        public string blockID { get; set; }

        [JsonProperty("Block No")]
        public string blockNo { get; set; }

        [JsonProperty("Orchard ID")]
        public string orchID { get; set; }

        [JsonProperty("Orchard")]
        public string orchNum { get; set; }

        [JsonProperty("Production Unit")]
        public string prodUnitID { get; set; }

        [JsonProperty("Production Unit Name")]
        public string prodUnitName { get; set; }

        [JsonProperty("Commodity")]
        public string commodity { get; set; }

        [JsonProperty("Cultivar")]
        public string cultivar { get; set; }
    }
}
