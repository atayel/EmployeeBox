namespace EmployeeBox.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeFileType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeFileType()
        {
            EmployeeFiles = new HashSet<EmployeeFile>();
        }

        public int EmployeeFileTypeID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeFile> EmployeeFiles { get; set; }
    }
}
