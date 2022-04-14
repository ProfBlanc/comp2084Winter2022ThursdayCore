using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace comp2084Winter2022ThursdayCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleAPIController : ControllerBase
    {
        // GET: api/<SimpleAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SimpleAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value with ID of " + id;
        }

        // POST api/<SimpleAPIController>
        [HttpPost]
        public string Post([FromBody] object value)
        {
            return "Create object with value = " + value;
        }

        // PUT api/<SimpleAPIController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] object value)
        {
            return "Updating record with ID = " + id + " with new value of " + value;
        }

        // DELETE api/<SimpleAPIController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Deleting record with ID = " + id;
        }
    }
}
