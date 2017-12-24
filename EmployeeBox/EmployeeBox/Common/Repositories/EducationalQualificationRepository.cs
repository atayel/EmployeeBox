using EmployeeBox.Common.Factories;
using EmployeeBox.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeBox.Common.Repositories
{
    public class EducationalQualificationRepository : IEducationalQualificationRepository
    {
        EntityModel _db = new EntityModel();

        public void Dispose()
        {
            _db.Dispose();
        }

        public EducationalQualification Find(int EducationalQualificationID)
        {
            return _db.EducationalQualifications.Find(EducationalQualificationID);
        }

        public IEnumerable<EducationalQualification> List()
        {
            return _db.EducationalQualifications.ToList();
        }
    }
}