namespace EmployeeBox.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeState
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeState()
        {
            EmployeeStateLogs = new HashSet<EmployeeStateLog>();
        }

        public int EmployeeStateID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeStateLog> EmployeeStateLogs { get; set; }
    }
}
