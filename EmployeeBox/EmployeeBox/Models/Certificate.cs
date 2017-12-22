namespace EmployeeBox.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Certificate
    {
        public int CertificateID { get; set; }

        public string Name { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        public double? Value { get; set; }

        public double? BackValue { get; set; }

        public double? ProfitMargin { get; set; }

        public int? CertificateTypeID { get; set; }

        public int? BankID { get; set; }

        public byte? State { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RegistrationDate { get; set; }

        public virtual Bank Bank { get; set; }

        public virtual CertificateType CertificateType { get; set; }
    }
}
