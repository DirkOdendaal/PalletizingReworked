using PalletizingReworked.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalletizingReworked.Gateway
{
    internal class GradeGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(Grade grade)
        {
            _dbContext.Grade.Add(grade);
            return _dbContext.SaveChanges() > 0;
        }

        public bool AddRange(List<Grade> grade)
        {
            _dbContext.Grade.AddRange(grade);
            return _dbContext.SaveChanges() > 0;
        }

        public List<string> GetAll()
        {
            return _dbContext.Grade.Select(b => b.grade).ToList();
        }
    }
}
