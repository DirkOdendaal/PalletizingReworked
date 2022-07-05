using PalletizingReworked.Gateway;
using PalletizingReworked.Models;
using System.Collections.Generic;

namespace PalletizingReworked.Manager
{
    internal class BrandManager
    {
        BrandGateway _brandsGateway = new BrandGateway();

        public bool Add(Brand brand)
        {
            return _brandsGateway.Add(brand);
        }
        public bool AddRange(List<Brand> brand)
        {
            return _brandsGateway.AddRange(brand);
        }

        public List<string> GetAll()
        {
            return _brandsGateway.GetAll();
        }
    }
}
