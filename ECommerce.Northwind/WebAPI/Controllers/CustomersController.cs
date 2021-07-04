using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            //Thread.Sleep(5000);

            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getcustomerbyid")]
        public IActionResult GetProductDetailById(string id)
        {
            var result = _customerService.GetCustomerDetailById(
                id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
