namespace EmployeeBox.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            EmployeeFiles = new HashSet<EmployeeFile>();
            EmployeeShares = new HashSet<EmployeeShare>();
            EmployeeSubscriptionFees = new HashSet<EmployeeSubscriptionFee>();
            EducationalQualifications = new HashSet<EducationalQualification>();
        }

        public int EmployeeID { get; set; }

        public decimal? NationalID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Address { get; set; }

        public decimal? PhoneNumber { get; set; }

        public string Photo { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? JoinDate { get; set; }

        public int? EmployeeStateLogID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeFile> EmployeeFiles { get; set; }

        public virtual EmployeeStateLog EmployeeStateLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeShare> EmployeeShares { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeSubscriptionFee> EmployeeSubscriptionFees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EducationalQualification> EducationalQualifications { get; set; }
    }
}
