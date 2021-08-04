using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SprintFoodOrderingSystem.Models;
using SprintProject.Repositories;



namespace SprintProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminRepository _repository;
        public AdminController(IAdminRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("additem")]
        public IActionResult AddItem(Menu menu)
        {
            try
            {
                _repository.AddItem(menu);
                return Ok("Item Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpDelete]
        [Route("DeleteItem/{menuId}")]
        public IActionResult DeleteItem(int menuId)
        {
            try
            {
                _repository.DeleteItem(menuId);
                return Ok("Item Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpGet]
        [Route("CustDetails/{custId}")]
        public object GetCustomers(int custId)
        {
            return _repository.GetCustomers(custId);
        }



        [HttpGet]
        [Route("MenuList")]
        public List<Menu> GetMenu()
        {
            return _repository.GetMenu();
        }



        [HttpGet]
        [Route("GetItem/{menuId}")]
        public Menu GetMenuItem(int menuId)
        {
            return _repository.GetMenuItem(menuId);



        }



        [HttpPut]
        [Route("Status")]
        public IActionResult OrderStatus(Order orders)
        {
            try
            {
                _repository.OrderStatus(orders);
                return Ok("OrderStatus Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult UpdateItem(Menu menu)
        {
            try
            {
                _repository.UpdateItem(menu);
                return Ok("Item Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}