namespace EmployeeBox.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EducationalQualification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EducationalQualification()
        {
            Employees = new HashSet<Employee>();
        }

        public int EducationalQualificationID { get; set; }

        [StringLength(50)]
        public string EducationalQualificationName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
