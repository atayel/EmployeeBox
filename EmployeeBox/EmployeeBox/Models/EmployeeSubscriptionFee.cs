namespace EmployeeBox.Models
{
    public partial class EmployeeSubscriptionFee
    {
        public int SubscriptionFeeID { get; set; }

        public int? EmployeeID { get; set; }

        public short? Year { get; set; }

        public decimal? SubscriptionFee { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
