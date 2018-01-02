namespace EmployeeBox.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

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

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public virtual Bank Bank { get; set; }

        public virtual CertificateType CertificateType { get; set; }
    }
}
