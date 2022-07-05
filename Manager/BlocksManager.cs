using PalletizingReworked.Gateway;
using PalletizingReworked.Models;
using System.Collections.Generic;

namespace PalletizingReworked.Manager
{
    internal class BlocksManager
    {
        BlocksGateway _blocksGateway = new BlocksGateway();

        public bool Add(Blocks blocks)
        {
            return _blocksGateway.Add(blocks);
        }
        public bool AddRange(List<Blocks> blocks)
        {
            return _blocksGateway.AddRange(blocks);
        }

        public List<Blocks> GetAll()
        {
            return _blocksGateway.GetAll();
        }

        public List<string> GetProdUnitListUnique()
        {
            return _blocksGateway.GetProdUnitListUnique();
        }

        public List<string> GetOrchListUniqueFilter(string prodUnit)
        {
            return _blocksGateway.GetOrchListUniqueFilter(prodUnit);
        }

        public List<string> GetBlocksListUniqueFilter(string orch)
        {
            return _blocksGateway.GetBlocksListUniqueFilter(orch);
        }
        public List<string> GetCommListUniqueFilter(string prodUnit, string block)
        {
            return _blocksGateway.GetCommListUniqueFilter(prodUnit, block);
        }
        public List<string> GetCultListUniqueFilter(string comm)
        {
            return _blocksGateway.GetCultListUniqueFilter(comm);
        }

        public Blocks GetRunRecord(string prodUnit, string orch, string block)
        {
            return _blocksGateway.GetRunRecord(prodUnit, orch, block);
        }

        public bool DeleteAllBlocks()
        {
            return _blocksGateway.DeleteAllBlocks();
        }
    }
}
