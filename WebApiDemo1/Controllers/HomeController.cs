using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo1.Models;

namespace WebApiDemo1.Controllers
{
    [Route("api/[controller]")] // URL Local Host
    [ApiController]

    public class HomeController : ControllerBase
    {
        //get : /api/home
        [HttpGet()]
        public string Get()
        {
            return "Hello world";
        }

        //get : /api/home/1
        [HttpGet("{id}")]
        public string GetDatetime(int id)
        {
            return System.DateTime.Now.ToString();
        }

        //get : /api/home/add/5
        [HttpGet("add/{days}")]

        public string GetNextDate(int days)
        {
            return DateTime.Now.AddDays(days).ToString();
        }
        [HttpGet("response")] // URL : //get : /api/home/response
        public HttpResponseMessage GetResponse()
        {
            var response = new HttpResponseMessage(
                System.Net.HttpStatusCode.BadRequest
                );
            response.Content = new StringContent("Response generated");
            
            return response;
        }

        [HttpGet("frequentlyused/{id}")]
        public IActionResult MostFrequentlyUsedStyle(int id = 0)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            if(id < 10)
            {
                //var obj1 = new { Id = id, Name = "KarthikNotFound" };
                return NotFound();
            }
            var obj = new { Id = id, Name = "Karthik" };
            return Ok(obj);
        }

        [HttpGet("Product/{id}")]
        public IActionResult GetProductDetails(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            if (id < 10)
            {
                //var obj1 = new { Id = id, Name = "KarthikNotFound" };
                return NotFound();
            }
            var obj = new Product{ ProductId = id, ProductName = "Laptops" };
            return Ok(obj);
        }
    }
}
