using PalletizingReworked.Models;
using System.Linq;

namespace PalletizingReworked.Gateway
{
    public class UserGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(User user)
        {
            _dbContext.Users.Add(user);
            return _dbContext.SaveChanges() > 0;
        }

        public User GetUser()
        {
            return _dbContext.Users.FirstOrDefault();
        }

        public bool DeleteCurrentUser()
        {
            var user = _dbContext.Users.FirstOrDefault();
            if (user == null)
            {
                return false;
            }
            _dbContext.Users.Remove(user);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
