using PalletizingReworked.Gateway;
using PalletizingReworked.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalletizingReworked.Manager
{
    internal class ScaleSettingsManager
    {
        ScaleSettingsGateway _settingsGateway = new ScaleSettingsGateway();

        public bool Add(ScaleSettings settings)
        {
            return _settingsGateway.Add(settings);
        }

        public ScaleSettings GetSettings()
        {
            return _settingsGateway.GetSettings();
        }

        public bool DeleteCurrentSettings()
        {
            return _settingsGateway.DeleteCurrentSettings();
        }
        public bool UpdateSettings()
        {
            return _settingsGateway.UpdateSettings();
        }

    }
}
