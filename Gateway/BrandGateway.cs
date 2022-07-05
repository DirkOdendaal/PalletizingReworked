using PalletizingReworked.Models;
using System.Collections.Generic;
using System.Linq;

namespace PalletizingReworked.Gateway
{
    internal class BrandGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(Brand brand)
        {
            _dbContext.Brand.Add(brand);
            return _dbContext.SaveChanges() > 0;
        }

        public bool AddRange(List<Brand> brand)
        {
            _dbContext.Brand.AddRange(brand);
            return _dbContext.SaveChanges() > 0;
        }

        public List<string> GetAll()
        {
            return _dbContext.Brand.Select(b => b.brand).ToList();
        }
    }
}
