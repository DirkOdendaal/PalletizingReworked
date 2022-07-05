using PalletizingReworked.Models;
using System.Collections.Generic;
using System.Linq;

namespace PalletizingReworked.Gateway
{
    internal class PackGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(Pack pack)
        {
            _dbContext.Pack.Add(pack);
            return _dbContext.SaveChanges() > 0;
        }

        public bool AddRange(List<Pack> pack)
        {
            _dbContext.Pack.AddRange(pack);
            return _dbContext.SaveChanges() > 0;
        }

        public List<string> GetAll()
        {
            return _dbContext.Pack.Select(b => b.packType).ToList();
        }

        public List<string> GetPackTypeFilterd(string brand)
        {
            return _dbContext.Pack.Where(b => b.brand == brand).Select(b => b.packType).ToList();
        }

        public string GetPackCountFilterd(string type)
        {
            return _dbContext.Pack.Where(b => b.packType == type).Select(b => b.QTY).FirstOrDefault();
        }
    }
}
