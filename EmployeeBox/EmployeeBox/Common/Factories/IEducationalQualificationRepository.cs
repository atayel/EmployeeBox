using EmployeeBox.Models;
using System;
using System.Collections.Generic;

namespace EmployeeBox.Common.Factories
{
    interface IEducationalQualificationRepository : IDisposable
    {
        EducationalQualification Find(int EducationalQualificationID);

        IEnumerable<EducationalQualification> List();
    }
}
