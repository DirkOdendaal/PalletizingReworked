using Newtonsoft.Json;

namespace PalletizingReworked.Models
{
    internal class Pack
    {
        public string Id { get; set; }

        [JsonProperty("Pack Type")]
        public string packType { get; set; }

        [JsonProperty("Brand")]
        public string brand { get; set; }

        [JsonProperty("Commodity")]
        public string commodity { get; set; }

        [JsonProperty("Units / Pallet")]
        public string QTY { get; set; }

        [JsonProperty("Empty Bin/Pallet Weight")]
        public string pallKg { get; set; }

        [JsonProperty("Empty Pack Weight (Kg)")]
        public string packKg { get; set; }
    }
}
