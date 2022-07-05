using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PalletizingReworked.Models
{
    public class PalletRecord : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [Browsable(false)]
        private string _key;

        [JsonProperty("ID")]
        [Browsable(false)]
        public string Id { get; set; }
        [JsonIgnore]
        public string key
        {
            get { return _key; }
            set
            {
                _key = value;
                OnPropertyChanged();
            }
        }
        [JsonProperty("Pallet Number")]
        public string Pallet_Number { get; set; }

        [JsonProperty("Production Unit")]
        [Browsable(false)]
        public string prodUnitId { get; set; }

        [JsonIgnore]
        public string Production_Unit { get; set; }

        [JsonProperty("Orchard")]
        [Browsable(false)]
        public string orchId { get; set; }

        [JsonIgnore]
        public string Orchard { get; set; }

        [JsonProperty("Block")]
        [Browsable(false)]
        public string blockId { get; set; }

        [JsonIgnore]
        public string Block { get; set; }

        [JsonProperty("Grade")]
        public string Grade { get; set; }

        [JsonProperty("Commodity")]
        public string Commodity { get; set; }

        [JsonProperty("Cultivar")]
        public string Cultivar { get; set; }

        [JsonProperty("Brand")]
        public string Brand { get; set; }

        [JsonProperty("Count/Size")]
        public string Count_Size { get; set; }

        [JsonProperty("Pack Type")]
        public string Pack_Type { get; set; }

        [JsonProperty("Pack QTY")]
        public string Pack_QTY { get; set; }

        [JsonProperty("Mass")]
        public string Weight { get; set; }

        [JsonProperty("Timestamp")]
        [Browsable(false)]
        public string Timestamp { get; set; }

        [Browsable(false)]
        [JsonIgnore]
        public string Date { get; set; }

        [JsonProperty("PC Name")]
        [Browsable(false)]
        public string PC_Name { get; set; }

        public PalletRecord()
        {
            this.key = null;
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
