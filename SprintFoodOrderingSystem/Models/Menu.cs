using System;
using System.Collections.Generic;

#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class Menu
    {
        public Menu()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string FoodCategory { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
