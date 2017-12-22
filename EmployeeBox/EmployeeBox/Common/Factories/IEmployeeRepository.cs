using EmployeeBox.Models;
using EmployeeBox.ViewModels;
using System;
using System.Collections.Generic;

namespace EmployeeBox.Common.Factories
{
    interface IEmployeeRepository : IDisposable
    {
        ContextState Create(Employee model);
        ContextState Edit(Employee model);
        ContextState Delete(Employee model);
        IEnumerable<Employee> List();
        IEnumerable<Employee> List(string employeeName = null,decimal? nationalID = null,
            DateTime? hireDateFrom = null,DateTime? hireDateTo=null,
            DateTime? joinDateFrom = null,DateTime? joinDateTo = null,
            EmployeeShare employeeShareFrom = null,EmployeeShare employeeShareTo = null,
            EducationalQualification employeeEducation = null);

        Employee Find(int id);
        Employee Find();
    }
}
