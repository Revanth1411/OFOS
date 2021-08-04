using System;
using System.Collections.Generic;

#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long? Mobile { get; set; }
        public string CustPassword { get; set; }
        public string CustStatus { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
