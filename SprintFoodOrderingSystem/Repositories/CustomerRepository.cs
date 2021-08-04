using SprintFoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SprintProject.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private Sprint1Context context = null;
        public CustomerRepository(Sprint1Context context)
        {
            this.context = context;
        }

        public void AddCustomer(Customer customer)
        {
            context.Add(customer);
            context.SaveChanges();
        }

        public void AddOrder(Order order)
        {
            context.Add(order);
            context.SaveChanges();
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            context.OrderItems.Add(orderItem);
            context.SaveChanges();
        }

        public void DeleteCustomer(int CustId)
        {
            Customer customer = context.Customers.SingleOrDefault(s => s.CustomerId ==
            CustId);
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public void DeleteOrder(int orderId)
        {
            Order order = context.Orders.SingleOrDefault(s => s.OrderId == orderId);
            context.Remove(orderId);
            context.SaveChanges();
        }

        public void DeleteOrderItem(int orderItemId)
        {
            OrderItem orderitem = context.OrderItems.SingleOrDefault(s => 
            s.OrderItemId == orderItemId);
            context.Remove(orderItemId);
            context.SaveChanges();
        }

        public void EditOrder(int orderId)
        {
            Order order = context.Orders.SingleOrDefault(s => s.OrderId == orderId);
            context.Update(order);
            context.SaveChanges();
        }

        public void EditOrderItem(int orderItemId)
        {
            OrderItem orderitem = context.OrderItems.SingleOrDefault(s => 
            s.OrderItemId == orderItemId);
            context.Update(orderItemId);
            context.SaveChanges();
        }

        public List<Menu> GetMenu() => context.Menus.ToList();
        public void MakePayment(Payment payment)
        {
            context.Add(payment);
            context.SaveChanges();
        }

        //public void TrackOrder(Order order)
        //{
            
                
        //}

        public void UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }
    }
}