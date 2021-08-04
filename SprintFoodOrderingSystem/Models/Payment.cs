using System;
using System.Collections.Generic;

#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? OrderId { get; set; }
        public decimal? TotalAmount { get; set; }
        public string PaidBy { get; set; }
        public string PaymentStatus { get; set; }

        public virtual Order Order { get; set; }
    }
}
