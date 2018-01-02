namespace EmployeeBox.Models
{
    public partial class EmployeeShare
    {
        public int EmployeeShareID { get; set; }

        public int? EmployeeID { get; set; }

        public int? EmployeeShareDateID { get; set; }

        public double? PersonalShare { get; set; }

        public double? OrganizationShare { get; set; }

        public byte? Accountable { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual EmployeeShareDate EmployeeShareDate { get; set; }
    }
}
