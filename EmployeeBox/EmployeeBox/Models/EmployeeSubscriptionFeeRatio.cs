namespace EmployeeBox.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeSubscriptionFeeRatio
    {
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
