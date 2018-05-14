using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingWebApp.Models;

namespace ParkingWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        // GET: api/Cars
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return new Car[] { new Car(){ Id= 1, Balance=23.0M, Ctype=CarType.Bus}, new Car(){ Id = 1, Balance = 340, Ctype = CarType.Motocycle } };
        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Cars
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
