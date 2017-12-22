namespace EmployeeBox.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NationalID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        public string Address { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PhoneNumber { get; set; }

        [Column(TypeName = "text")]
        public string Photo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HireDate { get; set; }

        [Column(TypeName = "date")]
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
