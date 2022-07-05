using Newtonsoft.Json;

namespace PalletizingReworked.Models
{
    public class Grade
    {
        public string Id { get; set; }

        [JsonProperty("Grade")]
        public string grade { get; set; }
    }
}
