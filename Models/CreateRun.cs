using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalletizingReworked.Models
{
    internal class CreateRun
    {
        public string Id { get; set; }
        public string prodUnitId { get; set; }
        public string prodUnitName { get; set; }
        public string orchardId { get; set; }
        public string orchardname { get; set; }
        public string blockId { get; set; }
        public string blockName { get; set; }
        public string cultivar { get; set; }
        public string commodity { get; set; }


    }
}
