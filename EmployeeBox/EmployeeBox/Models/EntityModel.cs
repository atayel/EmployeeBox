namespace EmployeeBox.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<CertificateType> CertificateTypes { get; set; }
        public virtual DbSet<EducationalQualification> EducationalQualifications { get; set; }
        public virtual DbSet<EmployeeFile> EmployeeFiles { get; set; }
        public virtual DbSet<EmployeeFileType> EmployeeFileTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeShareDate> EmployeeShareDates { get; set; }
        public virtual DbSet<EmployeeShare> EmployeeShares { get; set; }
        public virtual DbSet<EmployeeShareType> EmployeeShareTypes { get; set; }
        public virtual DbSet<EmployeeStateLog> EmployeeStateLogs { get; set; }
        public virtual DbSet<EmployeeState> EmployeeStates { get; set; }
        public virtual DbSet<EmployeeSubscriptionFee> EmployeeSubscriptionFees { get; set; }
        public virtual DbSet<EmployeeSubscriptionFeeRatio> EmployeeSubscriptionFeeRatios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certificate>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<EducationalQualification>()
                .HasMany(e => e.Employees)
                .WithMany(e => e.EducationalQualifications)
                .Map(m => m.ToTable("EmployeeEducationalQualifications").MapLeftKey("EducationalQualificationID").MapRightKey("EmployeeID"));

            modelBuilder.Entity<EmployeeFile>()
                .Property(e => e.State)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.NationalID)
                .HasPrecision(14, 14);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeSubscriptionFee>()
                .Property(e => e.SubscriptionFee)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeSubscriptionFeeRatio>()
                .Property(e => e.Ratio)
                .HasPrecision(18, 0);
        }
    }
}
