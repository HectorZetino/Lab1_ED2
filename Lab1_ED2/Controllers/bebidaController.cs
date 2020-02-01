using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Lab1_ED2.arbolB;
using Lab1_ED2.Models;

namespace Lab1_ED2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bebidaController : ControllerBase
    {
        // GET: api/bebida
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: api/bebida/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        // POST: api/bebida
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
