using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SprintFoodOrderingSystem.Models;


namespace SprintProject.Repositories
{
    public interface IAdminRepository
    {
        public void AddItem(Menu menu);
        public List<Menu> GetMenu();
        public void UpdateItem(Menu menu);
        public void DeleteItem(int menuId);
        public void OrderStatus(Order orders);
        public Menu GetMenuItem(int menuId);
        public object GetCustomers(int custId);
    }
}