using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SprintFoodOrderingSystem.Models;

namespace SprintProject.Repositories
{
    public interface ICustomerRepository
    {
        public void AddCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(int CustId);
        public List<Menu> GetMenu();
        //public void AddOrderItem(OrderItem orderItem);
        //public void DeleteOrderItem(int orderItemId);
        //public void EditOrderItem(int orderId);
        ////public void TrackOrder(int orderId);
        //public void AddOrder(Order order);
        //public void DeleteOrder(int orderId);
        //public void EditOrder(Order order);
        public void MakePayment(Payment payment);
    }
}