using System;
using System.Collections.Generic;
using EmployeeBox.Common.Factories;
using EmployeeBox.Models;
using EmployeeBox.ViewModels;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.Entity;
using System.Linq;

namespace EmployeeBox.Common.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EntityModel _db = new EntityModel();

        public void Dispose()
        {
            _db.Dispose();
        }

        public ContextState Create(Employee model)
        {
            try
            {
                _db.Employees.Add(model);
                _db.SaveChanges();
                return new ContextState {
                    State = true,
                    Value = null
                };
            }
            catch (DbUpdateException ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
            catch (DbEntityValidationException ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
            catch (ObjectDisposedException ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
            catch (Exception ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
        }

        public ContextState Delete(Employee model)
        {
            try
            {
                _db.Employees.Remove(model);
                _db.SaveChanges();
                return new ContextState
                {
                    State = true,
                    Value = null
                };
            }
            catch (DbUpdateException ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
            catch (DbEntityValidationException ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
            catch (ObjectDisposedException ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
            catch (Exception ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
        }

        public ContextState Edit(Employee model)
        {
            try
            {
                _db.Entry(model).State = EntityState.Modified;
                _db.SaveChanges();
                return new ContextState
                {
                    State = true,
                    Value = null
                };
            }
            catch (DbUpdateException ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
            catch (DbEntityValidationException ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
            catch (ObjectDisposedException ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
            catch (Exception ex)
            {
                return new ContextState
                {
                    State = false,
                    Value = ex
                };
            }
        }

        public Employee Find(int id)
        {
            return _db.Employees
                .Include(e => e.EmployeeFiles)
                .Include(e => e.EducationalQualifications)
                .Include(e => e.EmployeeShares)
                .Include(e => e.EmployeeStateLog)
                .Include(e => e.EmployeeSubscriptionFees)
                .Where(e => e.EmployeeID == id)
                .SingleOrDefault();
        }

        public IEnumerable<Employee> List(int? page = 1, int? pageSize = 10)
        {
            return _db.Employees
                .Include(e => e.EmployeeFiles)
                .Include(e => e.EducationalQualifications)
                .Include(e => e.EmployeeShares)
                .Include(e => e.EmployeeStateLog)
                .Include(e => e.EmployeeSubscriptionFees)
                .ToList().Skip(((int)page - 1) * (int)pageSize).Take((int)pageSize);
        }

        public IEnumerable<Employee> List(string employeeName = null,
            decimal? nationalID = default(decimal?),
            DateTime? hireDateFrom = default(DateTime?),DateTime? hireDateTo = default(DateTime?),
            DateTime? joinDateFrom = default(DateTime?),DateTime? joinDateTo = default(DateTime?),
            EmployeeShare employeeShareFrom = null,EmployeeShare employeeShareTo = null,
            EducationalQualification employeeEducation = null, int? page = 1, int? pageSize = 10)
        {
            var _query = from t in _db.Employees
                .Include(e => e.EmployeeFiles)
                .Include(e => e.EducationalQualifications)
                .Include(e => e.EmployeeShares)
                .Include(e => e.EmployeeStateLog)
                .Include(e => e.EmployeeSubscriptionFees) select t;

            if (employeeName != string.Empty)
                _query = _query.Where(e => e.Name == employeeName || e.Name.Contains(employeeName));

            if (nationalID > 0)
                _query = _query.Where(e => e.NationalID == nationalID);

            if (hireDateFrom != null && hireDateTo != null)
                _query = _query.Where(e => e.HireDate >= hireDateFrom && e.HireDate <= hireDateTo);
            else if (hireDateFrom != null && hireDateTo == null)
                _query = _query.Where(e => e.HireDate >= hireDateFrom);

            if (joinDateFrom != null && joinDateTo != null)
                _query = _query.Where(e => e.JoinDate >= joinDateFrom && e.JoinDate <= joinDateTo);
            else if (joinDateFrom != null && joinDateTo == null)
                _query = _query.Where(e => e.JoinDate >= joinDateFrom);

            if (employeeEducation != null)
                _query = _query.Where(e => e.EducationalQualifications.Contains(employeeEducation));

            if (employeeShareFrom != null && employeeShareTo != null)
                _query = _query.Where(e => e.EmployeeShares.Contains(employeeShareFrom) && e.EmployeeShares.Contains(employeeShareTo));
            else if (employeeShareFrom != null && employeeShareTo == null)
                _query = _query.Where(e => e.EmployeeShares.Contains(employeeShareFrom));

            return _query.ToList().Skip(((int)page - 1) * (int)pageSize).Take((int)pageSize);
        }

        public bool IsExist(string emplyeeName = null, decimal? nationalID = default(decimal?))
        {
            return _db.Employees
                .Where(e => e.Name == emplyeeName && e.NationalID == nationalID)
                .Count() > 0;
        }
    }
}