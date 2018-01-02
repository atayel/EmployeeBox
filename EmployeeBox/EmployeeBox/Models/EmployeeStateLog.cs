namespace EmployeeBox.Models
{
    using System;
    using System.Collections.Generic;

    public partial class EmployeeStateLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeStateLog()
        {
            Employees = new HashSet<Employee>();
        }

        public int EmployeeStateLogID { get; set; }

        public DateTime? TransactionDate { get; set; }

        public int? EmployeeID { get; set; }

        public int? EmployeeStateID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual EmployeeState EmployeeState { get; set; }
    }
}
