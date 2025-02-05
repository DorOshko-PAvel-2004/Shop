﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopModels.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class Admin : ControllerBase
    {
        // GET: api/<Admin>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Admin>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Admin>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Admin>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Admin>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
