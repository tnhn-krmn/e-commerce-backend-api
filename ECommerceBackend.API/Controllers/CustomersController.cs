using ECommerceBackend.Business.Abstract;
using ECommerceBackend.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceBackend.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        ICustomerService _customersService;
        public CustomersController(ICustomerService customerService)
        {
         _customersService = customerService;
        }

        [HttpGet("CustomerList")]
        public IActionResult Get()
        {
            var result = _customersService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("CustomerAdd")]
        public IActionResult Add(Customer customer)
        {
            var result = _customersService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("CustomerUpdate")]
        public IActionResult Update(Customer customer)
        {
            var result = _customersService.Update(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("CustomerDelete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customersService.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
