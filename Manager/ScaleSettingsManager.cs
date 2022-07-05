using PalletizingReworked.Gateway;
using PalletizingReworked.Models;

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
