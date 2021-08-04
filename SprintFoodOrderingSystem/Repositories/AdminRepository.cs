using SprintFoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SprintProject.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private Sprint1Context context = null;
        public AdminRepository(Sprint1Context context)
        {
            this.context= context;
        }
        public void AddItem(Menu menu)
        {
            context.Add(menu);
            context.SaveChanges();
        }

        public void DeleteItem(int menuId)
        {
            Menu menu = context.Menus.SingleOrDefault(s => s.MenuId ==
            menuId);
            context.Menus.Remove(menu);
            context.SaveChanges();
        }
        public object GetCustomers(int custId)
        {
            var data = (from cus in context.Customers
                        where cus.CustomerId == custId
                        select new
                        {
                            cus.FirstName,
                            cus.LastName,
                            cus.Email,
                            cus.Mobile,
                            cus.CustStatus
                        }).ToList();

            return data;

        }

        public List<Menu> GetMenu() => context.Menus.ToList();

        public Menu GetMenuItem(int menuId)
        {
            Menu menu = context.Menus.SingleOrDefault(s => s.MenuId == menuId);
            return menu;
        }

        public void OrderStatus(Order orders)
        {
            context.Orders.Update(orders);
            context.SaveChanges();
        }

        public void UpdateItem(Menu menu)
        {
            context.Menus.Update(menu);
            context.SaveChanges();
        }
    }
}