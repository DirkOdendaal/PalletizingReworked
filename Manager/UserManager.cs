using PalletizingReworked.Gateway;
using PalletizingReworked.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalletizingReworked.Manager
{
    public class UserManager
    {
        UserGateway _userGateway = new UserGateway();

        public bool Add(User user)
        {
            return _userGateway.Add(user);
        }

        public User GetUser()
        {
            return _userGateway.GetUser();
        }

        public bool DeleteCurrentUser()
        {
            return _userGateway.DeleteCurrentUser();
        }
    }
}
