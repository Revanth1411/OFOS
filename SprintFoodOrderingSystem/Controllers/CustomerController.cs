using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SprintFoodOrderingSystem.Models;
using SprintProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SprintFoodOrderingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _repository;
        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        //Add customer
        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            try
            {
                _repository.AddCustomer(customer);
                return Ok("Customer Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        

        // Make Payment By OrderId
        [HttpPost]
        [Route("MakePayment")]
        public IActionResult MakePayment(Payment payment)
        {
            try
            {
                _repository.MakePayment(payment);
                return Ok("payment Success");
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Update Customer Details
        [HttpPost]
        [Route("UpdateCustomerDetails")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            try
            {
                _repository.UpdateCustomer(customer);
                return Ok("Updated Customer Details");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Delete Customer By customerId
        [HttpDelete]
        [Route("DeleteCustomer/{customerId}")]
        public IActionResult DeleteCustomer(int customerId)
        {
            try
            {
                _repository.DeleteCustomer(customerId);
                return Ok("Deleted Customer");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
