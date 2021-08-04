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
            context.Orders.Add(order);
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
            context.Orders.Remove(order);
            context.SaveChanges();
        }

        public void DeleteOrderItem(int orderItemId)
        {
            OrderItem orderitem = context.OrderItems.SingleOrDefault(s => 
            s.OrderItemId == orderItemId);
            context.OrderItems.Remove(orderitem);
            context.SaveChanges();
        }

        public void EditOrder(int orderId)
        {
            //var orders = (from or in context.OrderItems
            //             where or.OrderId == orderId
            //             select or).ToList();
            
            //decimal? totalamount = 0;
            
            //foreach (var i in orders)
            //{
            //    decimal serving = Convert.ToDecimal(i.NoofServing);
            //    totalamount += (i.Amount * serving);
            //}

            Order order = context.Orders.SingleOrDefault(s => s.OrderId == orderId);
            //order.TotalAmount = totalamount;
            context.Orders.Update(order);
            context.SaveChanges();
        }

        public void EditOrderItem(int orderItemId)
        {
            OrderItem orderitem = context.OrderItems.SingleOrDefault(s => 
            s.OrderItemId == orderItemId);
            context.OrderItems.Update(orderitem);
            context.SaveChanges();
        }

        public List<Menu> GetMenu() => context.Menus.ToList();

        public List<Order> GetOrders() => context.Orders.ToList();
        

        public void MakePayment(Payment payment)
        {
            context.Add(payment);
            context.SaveChanges();
        }

        public string TrackOrder(int orderId)
        {
            Order order = context.Orders.SingleOrDefault(s => s.OrderId == orderId);
            return $"Order Status: {order.OrderStatus}";
        }

        public void UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }
    }
}