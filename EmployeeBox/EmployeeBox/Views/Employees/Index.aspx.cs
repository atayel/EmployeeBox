using EmployeeBox.Common.Factories;
using EmployeeBox.Common.Repositories;
using EmployeeBox.ViewModels;
using System;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeBox.Views.Employees
{
    public partial class Index : Page
    {
        private IEmployeeRepository _repository;
        private ICommonRepository _common;

        #region Form_Events
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEmployeeShareFrom.Attributes["type"] = "number";
            txtEmployeeShareTo.Attributes["type"] = "number";

            _repository = new EmployeeRepository();
            _common = new CommonRepository();

            if (!Page.IsPostBack)
            {
                var _results = _repository.List(1, 10);
                PopulateTable(_common.ConvertIEnumerableToDataTable(_results));

                employeeEducationList.Items.Add(new ListItem {
                    Text = "أختر المؤهل التعليمي",
                    Value = "0"
                });

                foreach (var item in _repository.EducationalQualificationList())
                {
                    employeeEducationList.Items.Add(new ListItem {
                        Text = item.EducationalQualificationName,
                        Value = item.EducationalQualificationID.ToString()
                    });
                }
            }
        }
        #endregion

        #region Button_Events
        protected void btnSearch_ServerClick(object sender,EventArgs e)
        {
            var _employee = new EmployeeViewModel();

            if (!string.IsNullOrEmpty(txtName.Value))
                _employee.Name = txtName.Value;

            if (!string.IsNullOrEmpty(txtNationalID.Value))
                _employee.NationalID = decimal.Parse(txtNationalID.Value.ToString());

            if (!string.IsNullOrEmpty(txtHireDateFrom.Value))
                _employee.HireDateFrom = DateTime.ParseExact(txtHireDateFrom.Value,"dd/MM/yyyy",null);

            if (!string.IsNullOrEmpty(txtHireDateTo.Value))
                _employee.HireDateFrom = DateTime.ParseExact(txtHireDateTo.Value, "dd/MM/yyyy", null);

            if (!string.IsNullOrEmpty(txtJoinDateFrom.Value))
                _employee.JoinDateFrom = DateTime.ParseExact(txtJoinDateFrom.Value, "dd/MM/yyyy", null);

            if (!string.IsNullOrEmpty(txtJoinDateTo.Value))
                _employee.JoinDateTo = DateTime.ParseExact(txtJoinDateTo.Value, "dd/MM/yyyy", null);

            if (!string.IsNullOrEmpty(txtEmployeeShareFrom.Value))
                _employee.EmployeeShareFrom = double.Parse(txtEmployeeShareFrom.Value);

            if (!string.IsNullOrEmpty(txtEmployeeShareTo.Value))
                _employee.EmployeeShareTo = double.Parse(txtEmployeeShareTo.Value);

            if (employeeEducationList.Value != "0")
                _employee.EducationalQualifications = Convert.ToInt32(employeeEducationList.Value);

            var _results = _repository.List(_employee.Name, _employee.NationalID,
                _employee.HireDateFrom,_employee.HireDateTo,_employee.JoinDateFrom,_employee.JoinDateTo,
                _employee.EmployeeShareFrom,_employee.EmployeeShareTo,_employee.EducationalQualifications);

            PopulateTable(_common.ConvertIEnumerableToDataTable(_results));
        }
        #endregion

        #region Popualte_Table_With_Rows
        private void PopulateTable(DataTable _data)
        {
            StringBuilder _html = new StringBuilder();

            foreach (DataRow _row in _data.Rows)
            {
                _html.Append("<tr>");

                _html.Append("<td>");
                _html.Append(_row[0]);
                _html.Append("</td>");

                _html.Append("<td>");
                _html.Append(_row[2]);
                _html.Append("</td>");

                _html.Append("<td>");
                _html.Append(_row[6]);
                _html.Append("</td>");

                _html.Append("<td>");
                _html.Append(@"<button class='btn btn-xs btn-success'><i class='fa fa-eye'></i></button>
                                    <button class='btn btn-xs btn-warning'><i class='fa fa-pencil-square-o'></i></button>
                                    <button class='btn btn-xs btn-danger'><i class='fa fa-minus'></i></button>");
                _html.Append("</td>");

                _html.Append("</tr>");
            }
            tableBody.InnerHtml = _html.ToString();
        }
        #endregion
    }
}