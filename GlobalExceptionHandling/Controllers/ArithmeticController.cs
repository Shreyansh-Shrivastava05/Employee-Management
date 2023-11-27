using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalExceptionHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArithmeticController : ControllerBase
    {
        // GET: api/<ArithmeticController>
        [HttpGet]
        public int Get()
        {
            return 0;
        }

        // GET api/<ArithmeticController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArithmeticController>
        [HttpPost]
        public IActionResult Post([FromQuery] int a,[FromQuery] int b)
        {
            return Ok(a / b);
        }

        // PUT api/<ArithmeticController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArithmeticController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
