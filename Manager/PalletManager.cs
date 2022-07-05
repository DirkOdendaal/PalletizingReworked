using PalletizingReworked.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace Palletizing.Manager
{
    internal class PalletsManager
    {
        private PalletsGateway _palletsGateway = new PalletsGateway();

        public bool Add(PalletRecord pallet)
        {
            return _palletsGateway.Add(pallet);
        }

        public BindingList<PalletRecord> GetAll()
        {
            return _palletsGateway.GetAll();
        }

        public List<PalletRecord> GetNotUploadPallet()
        {
            return _palletsGateway.GetNotUploadedPallet();
        }

        public PalletRecord GetPallet(string pallNumber)
        {
            return _palletsGateway.GetPallet(pallNumber);
        }

        public bool UpdatePallet(string pallet)
        {
            return _palletsGateway.UpdatePallet(pallet);
        }
    }
}
