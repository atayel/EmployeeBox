namespace EmployeeBox.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeShareDate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeShareDate()
        {
            EmployeeShares = new HashSet<EmployeeShare>();
        }

        public int EmployeeShareDateID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? EmployeeShareTypeID { get; set; }

        public DateTime? Date { get; set; }

        public virtual EmployeeShareType EmployeeShareType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeShare> EmployeeShares { get; set; }
    }
}
