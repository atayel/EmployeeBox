using EmployeeBox.Models;
using System;

namespace EmployeeBox.Common.Factories
{
    interface IEmployeeShareRepository : IDisposable
    {
        EmployeeShare Find(int EmployeeShareID);
        EmployeeShare Find(double? PersonalShare, double? OrganizationShare);
        EmployeeShare Find(double? PersonalShare);
    }
}
