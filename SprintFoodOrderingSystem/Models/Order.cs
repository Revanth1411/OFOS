using System;
using System.Collections.Generic;

#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class Order
    {
        //public Order()
        //{
        //    OrderItems = new HashSet<OrderItem>();
        //    Payments = new HashSet<Payment>();
        //}

        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public int CustomerId { get; set; }
        public string OrderStatus { get; set; }

        public virtual Customer Customer { get; set; }
        //public virtual ICollection<OrderItem> OrderItems { get; set; }
        //public virtual ICollection<Payment> Payments { get; set; }
    }
}
