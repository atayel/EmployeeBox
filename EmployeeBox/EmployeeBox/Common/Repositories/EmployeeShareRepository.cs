using EmployeeBox.Common.Factories;
using EmployeeBox.Models;
using System.Linq;

namespace EmployeeBox.Common.Repositories
{
    public class EmployeeShareRepository : IEmployeeShareRepository
    {
        EntityModel _db = new EntityModel();

        public void Dispose()
        {
            _db.Dispose();
        }

        public EmployeeShare Find(int EmployeeShareID)
        {
            return _db.EmployeeShares.Find(EmployeeShareID);
        }

        public EmployeeShare Find(double? PersonalShare)
        {
            return _db.EmployeeShares.Where(e => e.PersonalShare == PersonalShare).SingleOrDefault();
        }

        public EmployeeShare Find(double? PersonalShare, double? OrganizationShare)
        {
            return _db.EmployeeShares.Where(e => e.PersonalShare == PersonalShare && e.OrganizationShare == OrganizationShare).FirstOrDefault();
        }
    }
}