using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopModels.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperAdmin : ControllerBase
    {
        // GET: api/<SuperAdmin>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SuperAdmin>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SuperAdmin>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SuperAdmin>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SuperAdmin>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
