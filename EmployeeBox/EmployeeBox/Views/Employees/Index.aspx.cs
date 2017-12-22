using EmployeeBox.Common.Factories;
using EmployeeBox.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeBox.Views.Employees
{
    public partial class Index : System.Web.UI.Page
    {
        private IEmployeeRepository _repository;
        protected void Page_Load(object sender, EventArgs e)
        {
            _repository = new EmployeeRepository();
            var x = _repository.List("asd", 1324651513,
                DateTime.Now.AddYears(-1),
                DateTime.Now.AddYears(5),
                DateTime.Now.AddMonths(-6),DateTime.Now.AddYears(2));

            x.ToList();
        }
    }
}