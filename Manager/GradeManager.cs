using PalletizingReworked.Gateway;
using PalletizingReworked.Models;
using System.Collections.Generic;

namespace PalletizingReworked.Manager
{
    internal class GradeManager
    {
        GradeGateway _gradeGateway = new GradeGateway();

        public bool Add(Grade grade)
        {
            return _gradeGateway.Add(grade);
        }

        public bool AddRange(List<Grade> grade)
        {
            return _gradeGateway.AddRange(grade);
        }

        public List<string> GetAll()
        {
            return _gradeGateway.GetAll();
        }
    }
}
