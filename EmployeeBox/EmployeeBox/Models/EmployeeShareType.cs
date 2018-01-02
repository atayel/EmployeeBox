namespace EmployeeBox.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeShareType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeShareType()
        {
            EmployeeShareDates = new HashSet<EmployeeShareDate>();
        }

        public int EmployeeShareTypeID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public double? PersonalRatio { get; set; }

        public double? OrganizationRatio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeShareDate> EmployeeShareDates { get; set; }
    }
}
