namespace EmployeeBox.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeSubscriptionFee")]
    public partial class EmployeeSubscriptionFee
    {
        [Key]
        public int SubscriptionFeeID { get; set; }

        public int? EmployeeID { get; set; }

        public short? Year { get; set; }

        public decimal? SubscriptionFee { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
