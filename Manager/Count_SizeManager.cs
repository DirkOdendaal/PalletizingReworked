using PalletizingReworked.Gateway;
using PalletizingReworked.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalletizingReworked.Manager
{
    internal class Count_SizeManager
    {
        Count_SizeGateway _countGateway = new Count_SizeGateway();

        public bool Add(Count count)
        {
            return _countGateway.Add(count);
        }
        public bool AddRange(List<Count> count)
        {
            return _countGateway.AddRange(count);
        }

        public List<string> GetCountCommFiltered(string comm)
        {
            return _countGateway.GetCountCommFiltered(comm);
        }
    }
}
