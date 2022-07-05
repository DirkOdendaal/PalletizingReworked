using PalletizingReworked.Gateway;
using PalletizingReworked.Models;
using System.Collections.Generic;

namespace PalletizingReworked.Manager
{
    internal class PackManager
    {
        PackGateway _packGateway = new PackGateway();

        public bool Add(Pack pack)
        {
            return _packGateway.Add(pack);
        }

        public bool AddRange(List<Pack> pack)
        {
            return _packGateway.AddRange(pack);
        }

        public List<string> GetAll()
        {
            return _packGateway.GetAll();
        }

        public List<string> GetPackTypeFilterd(string brand)
        {
            return _packGateway.GetPackTypeFilterd(brand);
        }

        public string GetPackCountFilterd(string type)
        {
            return _packGateway.GetPackCountFilterd(type);
        }
    }
}
