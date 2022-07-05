using PalletizingReworked.Models;
using System.Linq;

namespace PalletizingReworked.Gateway
{
    internal class CreateRunGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(CreateRun run)
        {
            _dbContext.CreateRun.Add(run);
            return _dbContext.SaveChanges() > 0;
        }

        public CreateRun GetRun()
        {
            return _dbContext.CreateRun.FirstOrDefault();
        }

        public bool DeleteCurrentRun()
        {
            var run = _dbContext.CreateRun.FirstOrDefault();
            if (run == null)
            {
                return false;
            }
            _dbContext.CreateRun.Remove(run);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
