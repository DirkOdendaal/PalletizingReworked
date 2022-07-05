using PalletizingReworked.Models;
using System.Linq;

namespace PalletizingReworked.Gateway
{
    internal class ScaleSettingsGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(ScaleSettings settings)
        {
            _dbContext.ScaleSettings.Add(settings);
            return _dbContext.SaveChanges() > 0;
        }

        public ScaleSettings GetSettings()
        {
            return _dbContext.ScaleSettings.FirstOrDefault();
        }

        public bool DeleteCurrentSettings()
        {
            var settings = _dbContext.ScaleSettings.FirstOrDefault();
            if (settings == null)
            {
                return false;
            }
            _dbContext.ScaleSettings.Remove(settings);
            return _dbContext.SaveChanges() > 0;
        }

        public bool UpdateSettings()
        {
            var data = _dbContext.ScaleSettings.FirstOrDefault();
            if(data == null)
            {
                return false;
            }
            int newCount = data.palId + 1;
            data.palId = newCount;
            _dbContext.ScaleSettings.Update(data);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
