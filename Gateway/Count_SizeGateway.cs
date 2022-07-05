using PalletizingReworked.Models;
using System.Collections.Generic;
using System.Linq;

namespace PalletizingReworked.Gateway
{
    internal class Count_SizeGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(Count count)
        {
            _dbContext.Count.Add(count);
            return _dbContext.SaveChanges() > 0;
        }

        public bool AddRange(List<Count> count)
        {
            _dbContext.Count.AddRange(count);
            return _dbContext.SaveChanges() > 0;
        }

        public List<string> GetCountCommFiltered(string comm)
        {
            return _dbContext.Count.Where(b => b.commod.Contains(comm)).Select(b => b.count).ToList();
        }
    }
}
