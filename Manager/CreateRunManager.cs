using PalletizingReworked.Gateway;
using PalletizingReworked.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalletizingReworked.Manager
{
    internal class CreateRunManager
    {
        CreateRunGateway _runGateway = new CreateRunGateway();

        public bool Add(CreateRun run)
        {
            return _runGateway.Add(run);
        }

        public CreateRun GetRun()
        {
            return _runGateway.GetRun();
        }

        public bool DelteCurrentRun()
        {
            return _runGateway.DeleteCurrentRun();
        }
    }
}
