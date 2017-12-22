namespace EmployeeBox.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmployeeSubscriptionFeeRatio
    {
        [Key]
        public int RatioID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public short? Year { get; set; }

        public decimal? Ratio { get; set; }

        public DateTime? RatioData { get; set; }
    }
}
