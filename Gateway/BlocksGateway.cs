using PalletizingReworked.Models;
using System.Collections.Generic;
using System.Linq;

namespace PalletizingReworked.Gateway
{
    internal class BlocksGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();
        public bool Add(Blocks blocks)
        {
            _dbContext.Blocks.Add(blocks);
            return _dbContext.SaveChanges() > 0;
        }

        public bool AddRange(List<Blocks> blocks)
        {
            _dbContext.Blocks.AddRange(blocks);
            return _dbContext.SaveChanges() > 0;
        }

        public List<string> GetProdUnitListUnique()
        {
            return _dbContext.Blocks.Select(b => b.prodUnitName).Distinct().ToList();
        }

        public List<string> GetOrchListUniqueFilter(string produnitName)
        {
            return _dbContext.Blocks.Where(b => b.prodUnitName == produnitName).Select(b => b.orchNum).Distinct().ToList();
        }

        public List<string> GetBlocksListUniqueFilter(string orch)
        {
            return _dbContext.Blocks.Where(b => b.orchNum == orch).Select(b => b.blockNo).Distinct().ToList();
        }

        public List<string> GetCommListUniqueFilter(string prodUnit, string block)
        {
            return _dbContext.Blocks.Where(b => b.prodUnitName == prodUnit).Where(b => b.blockNo == block).Where(b => b.commodity != null).Select(b => b.commodity).Distinct().ToList();
        }
        public List<string> GetCultListUniqueFilter(string comm)
        {
            return _dbContext.Blocks.Where(b => b.commodity == comm).Where(b => b.cultivar != null).Select(b => b.cultivar).Distinct().ToList();
        }

        public Blocks GetRunRecord(string prodUnit, string orch, string block)
        {
            return _dbContext.Blocks.Where(b => b.prodUnitName == prodUnit).Where(b => b.blockNo == block).Where(b => b.orchNum == orch).FirstOrDefault();
        }

        public List<Blocks> GetAll()
        {
            return _dbContext.Blocks.ToList();
        }

        public bool DeleteAllBlocks()
        {
            var blocks = _dbContext.Blocks.ToList();
            if (blocks == null)
            {
                return false;
            }
            _dbContext.Blocks.RemoveRange(blocks);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
