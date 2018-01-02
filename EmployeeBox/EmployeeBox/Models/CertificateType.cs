namespace EmployeeBox.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CertificateType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CertificateType()
        {
            Certificates = new HashSet<Certificate>();
        }

        public int CertificateTypeID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? ProfitRateByMonth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certificate> Certificates { get; set; }
    }
}
