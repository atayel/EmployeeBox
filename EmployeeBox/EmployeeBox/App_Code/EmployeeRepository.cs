using System;
using System.Collections.Generic;
using EmployeeBox.Models;
using EmployeeBox.ViewModels;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeBox.App_Code
{
    public class EmployeeRepository
    {
        SqlConnection _db;
        SqlCommand _com;
        public EmployeeRepository()
        {
            _db = new SqlConnection(ConnectionClass._connection);
        }

        internal void Dispose()
        {
            _db.Close();
            _db.Dispose();
        }

        #region Create_Functions
        internal ContextState Create(Employee model)
        {
            try
            {
                _com = new SqlCommand(@"INSERT INTO Employees
                      (NationalID, Name, BirthDate, Address, PhoneNumber, Photo, HireDate, JoinDate, EmployeeStateLogID)
                        VALUES     (" + model.NationalID + ",'" + model.Name + "'," + model.BirthDate + ",'" + model.Address + "'," +
                        model.PhoneNumber + ",'" + model.Photo + "'," + model.HireDate + "," + model.JoinDate + ","+ model.EmployeeStateLogID +")",_db);
                _db.Open();
                _com.ExecuteNonQuery();
                _db.Close();
                return new ContextState {
                    State = true
                };
            }
            catch (Exception ex)
            {
                return new ContextState
                {
                    State = false,
                    ErrorMessage = ex.Message,
                };
            }
        }

        internal ContextState Create(EmployeeFile model)
        {
            try
            {
                //SqlCommand _com = new SqlCommand(@"INSERT INTO Employees
                //      (NationalID, Name, BirthDate, Address, PhoneNumber, Photo, HireDate, JoinDate, EmployeeStateLogID)
                //        VALUES     (" + model.NationalID + ",'" + model.Name + "'," + model.BirthDate + ",'" + model.Address + "'," +
                //        model.PhoneNumber + ",'" + model.Photo + "'," + model.HireDate + "," + model.JoinDate + "," + model.EmployeeStateLogID + ")", _db);
                //_db.Open();
                //_com.ExecuteNonQuery();
                //_db.Close();
                return new ContextState
                {
                    State = true,
                    //Value = null
                };
            }
            catch (Exception ex)
            {
                return new ContextState
                {
                    State = false,
                    //Value = ex
                };
            }
        }
        #endregion

        #region Edit_Functions
        internal ContextState Edit(Employee model)
        {
            try
            {
                SqlCommand _com = new SqlCommand(@"UPDATE    Employees
            SET NationalID = " + model.NationalID + " , Name ='" + model.Name + "', BirthDate = " + model.BirthDate
            + ", Address = '" + model.Address + "', PhoneNumber = " + model.PhoneNumber + ", Photo = '" + model.Photo
            + "', HireDate = " + model.HireDate + " , JoinDate = " + model.JoinDate + ", EmployeeStateLogID = " + model.EmployeeStateLogID
            + " WHERE (EmployeeID = " + model.EmployeeID + ")", _db);
                return new ContextState
                {
                    State = true,
                    //Value = null
                };
            }
            catch (Exception ex)
            {
                return new ContextState
                {
                    State = false,
                    //Value = ex
                };
            }
        }
        #endregion

        #region Delete_Functions
        internal ContextState Delete(Employee model)
        {
            try
            {
                SqlCommand _com = new SqlCommand(@"DELETE FROM Employees
                WHERE     (EmployeeID = " + model.EmployeeID + ")", _db);
                _db.Open();
                _com.ExecuteNonQuery();
                _db.Close();
                return new ContextState
                {
                    State = true,
                    //Value = null
                };
            }
            catch (Exception ex)
            {
                return new ContextState
                {
                    State = false,
                    //Value = ex
                };
            }
        }
        #endregion

        internal Employee Find(int id)
        {
            var model = new Employee();
            SqlCommand _com = new SqlCommand(@"SELECT     EmployeeID, NationalID, Name, BirthDate, Address,
                PhoneNumber, Photo, HireDate, JoinDate, EmployeeStateLogID FROM         Employees
                WHERE     (EmployeeID = " + id + ")", _db);

            _db.Open();
            SqlDataReader _dr = _com.ExecuteReader(CommandBehavior.SingleRow);
            if (_dr.HasRows)
                while (_dr.Read())
                {
                    model.EmployeeID = Convert.ToInt32(_dr["EmployeeID"]);
                    model.Name = _dr["Name"].ToString();
                    model.NationalID = decimal.Parse(_dr["NationalID"].ToString());
                    model.BirthDate = DateTime.ParseExact(_dr["BirthDate"].ToString(), "dd/MM/yyyy", null);
                    model.Address = _dr["Address"].ToString();
                    model.PhoneNumber = decimal.Parse(_dr["PhoneNumber"].ToString());
                    model.Photo = _dr["Photo"].ToString();
                    model.HireDate = DateTime.ParseExact(_dr["HireDate"].ToString(), "dd/MM/yyyy", null);
                    model.JoinDate = DateTime.ParseExact(_dr["JoinDate"].ToString(), "dd/MM/yyyy", null);
                    model.EmployeeStateLogID = Convert.ToInt32(_dr["EmployeeStateLogID"].ToString());
                }

            _dr.Close();
            _db.Close();

            return model;
        }

        internal IEnumerable<Employee> List(int? page = 1 , int? pageSize = 10)
        {
            List<Employee> _list = new List<Employee>();
            SqlCommand _com = new SqlCommand(@"SELECT     EmployeeID, NationalID, Name, BirthDate,
            Address, PhoneNumber, Photo, HireDate, JoinDate, EmployeeStateLogID
            FROM         Employees
            WHERE     EmployeeID BETWEEN ((" + page + " -1 ) * " + pageSize + " + 1)  AND (" + page + " * " + pageSize + ")",_db);
            _db.Open();
            SqlDataReader _dr = _com.ExecuteReader();
            if (_dr.HasRows)
                while (_dr.Read())
                {
                    _list.Add(new Employee
                    {
                        EmployeeID = Convert.ToInt32(_dr[0]),
                        NationalID = decimal.Parse(_dr[1].ToString()),
                        Name = _dr[2].ToString(),
                        BirthDate = Convert.ToDateTime(_dr[3].ToString()),
                        Address = _dr[4].ToString(),
                        PhoneNumber = decimal.Parse(_dr[5].ToString()),
                        Photo = _dr[6].ToString(),
                        HireDate = Convert.ToDateTime(_dr[7].ToString()),
                        JoinDate = Convert.ToDateTime(_dr[8].ToString())
                    });
                }

            _dr.Close();
            _db.Close();
            return _list;
        }

        internal IEnumerable<Employee> List(string employeeName = null,
            decimal? nationalID = default(decimal?),
            DateTime? hireDateFrom = default(DateTime?),DateTime? hireDateTo = default(DateTime?),
            DateTime? joinDateFrom = default(DateTime?),DateTime? joinDateTo = default(DateTime?),
            double? employeeShareFrom = default(double?), double? employeeShareTo = default(double?),
            int? employeeEducation = 0, int? page = 1, int? pageSize = 10)
        {
            var _query = @"SELECT     Employees.EmployeeID, Employees.NationalID, Employees.Name, Employees.BirthDate, Employees.Address, Employees.PhoneNumber, Employees.Photo, Employees.HireDate, 
                      Employees.JoinDate, Employees.EmployeeStateLogID, EducationalQualifications.EducationalQualificationName, EmployeeShares.PersonalShare
FROM         Employees LEFT JOIN
                      EmployeeEducationalQualifications ON Employees.EmployeeID = EmployeeEducationalQualifications.EmployeeID LEFT JOIN
                      EducationalQualifications ON EmployeeEducationalQualifications.EducationalQualificationID = EducationalQualifications.EducationalQualificationID LEFT JOIN
                      EmployeeShares ON Employees.EmployeeID = EmployeeShares.EmployeeID
            WHERE     Employees.EmployeeID BETWEEN ((" + page + " -1 ) * " + pageSize + " +1)  AND (" + page + " * " + pageSize + ")";

            if (employeeName != string.Empty)
                _query += @" AND ( Employees.Name LIKE '%" + employeeName +"%' )";

            if (nationalID > 0)
                _query += @" AND ( Employees.NationalID  LIKE %" + nationalID + "% )";

            if (hireDateFrom != null && hireDateTo != null)
                _query += @" AND ( Employees.HireDate >= '" + hireDateFrom + "' AND  Employees.HireDate <= '" + hireDateTo +"')";
            else if (hireDateFrom != null && hireDateTo == null)
                _query += @" AND ( Employees.HireDate >= '" + hireDateFrom + "')";

            if (joinDateFrom != null && joinDateTo != null)
                _query += @" AND ( Employees.JoinDate >= '" + joinDateFrom + "' AND  Employees.JoinDate <= '" + joinDateTo + "')";
            else if (joinDateFrom != null && joinDateTo == null)
                _query += @"AND ( Employees.JoinDate >= '" + joinDateFrom + "')";

            if (employeeEducation > 0)
                _query += @" AND (EducationalQualifications.EducationalQualificationID = " + employeeEducation +")";

            if (employeeShareFrom > 0 && employeeShareTo > 0)
                _query += @"AND     (EmployeeShares.PersonalShare >=  "+ employeeShareFrom + " AND EmployeeShares.PersonalShare <= "+ employeeShareTo +")";
            else if (employeeShareFrom > 0 && employeeShareTo <= 0)
                _query += @" AND     (EmployeeShares.PersonalShare >=  " + employeeShareFrom + ")";

            List<Employee> _list = new List<Employee>();
            SqlCommand _com = new SqlCommand(_query,_db);
            _db.Open();
            SqlDataReader _dr = _com.ExecuteReader();
            if (_dr.HasRows)
                while (_dr.Read())
                {
                    _list.Add(new Employee
                    {
                        EmployeeID = Convert.ToInt32(_dr[0]),
                        NationalID = decimal.Parse(_dr[1].ToString()),
                        Name = _dr[2].ToString(),
                        BirthDate = Convert.ToDateTime(_dr[3].ToString()),
                        Address = _dr[4].ToString(),
                        PhoneNumber = decimal.Parse(_dr[5].ToString()),
                        Photo = _dr[6].ToString(),
                        HireDate = Convert.ToDateTime(_dr[7].ToString()),
                        JoinDate = Convert.ToDateTime(_dr[8].ToString())
                    });
                }

            _dr.Close();
            _db.Close();
            return _list;
        }

        internal bool IsExist(string emplyeeName = null, decimal? nationalID = default(decimal?))
        {
            bool _exist = false;
            var model = new Employee();
            SqlCommand _com = new SqlCommand(@"SELECT     EmployeeID, NationalID, Name, BirthDate, Address,
                PhoneNumber, Photo, HireDate, JoinDate, EmployeeStateLogID FROM         Employees
                WHERE     (NationalID = " + nationalID + " AND Name = '"+ emplyeeName +"')",_db);

            _db.Open();
            SqlDataReader _dr = _com.ExecuteReader(CommandBehavior.SingleRow);
            if (_dr.HasRows)
                _exist = true;

            _dr.Close();
            _db.Close();
            return _exist;
        }

        internal IEnumerable<EducationalQualification> EducationalQualificationList()
        {
            List<EducationalQualification> _list = new List<EducationalQualification>();
            SqlCommand _com = new SqlCommand(@"SELECT     EducationalQualificationID, EducationalQualificationName
FROM         EducationalQualifications",_db);
            _db.Open();
            SqlDataReader _dr = _com.ExecuteReader();
            if (_dr.HasRows)
                while (_dr.Read())
                {
                    _list.Add(new EducationalQualification
                    {
                        EducationalQualificationID = Convert.ToInt32(_dr[0]),
                        EducationalQualificationName = _dr[1].ToString()
                    });
                }

            _dr.Close();
            _db.Close();
            return _list;
        }
    }
}