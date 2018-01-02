namespace EmployeeBox.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeFile
    {
        public int EmployeeFileID { get; set; }

        public int? EmployeeID { get; set; }

        public string Name { get; set; }

        public int? EmployeeFileTypeID { get; set; }

        [StringLength(10)]
        public string State { get; set; }

        public string FileUrl { get; set; }

        public virtual EmployeeFileType EmployeeFileType { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
