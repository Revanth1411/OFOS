using System;
using System.Collections.Generic;

#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class OrderItem
    {
        public int OrderId { get; set; }
        public int MenuId { get; set; }
        public decimal? Amount { get; set; }
        public int? NoofServing { get; set; }
        public decimal? Total { get; set; }
        public int OrderItemId { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual Order Order { get; set; }
    }
}
