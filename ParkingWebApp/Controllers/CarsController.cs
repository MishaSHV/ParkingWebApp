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
    public class CarsController : ControllerBase
    {
        // GET: api/Cars
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return new Car[] { new Car(){ Id= 1, Balance=23.0M, Ctype=CarType.Bus.ToString()}, new Car(){ Id = 1, Balance = 340, Ctype = CarType.Motocycle.ToString() } };
        }

        // GET: api/Cars/5
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(new Car { Id = id, Balance = 23.0M, Ctype = CarType.Bus.ToString() });
            //else return NotFound();
        }

        // POST: api/Cars
        [HttpPost]
        public IActionResult Post([FromBody]Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return CreatedAtAction("GET", new { id = car.Id, CarType = car.Ctype,  car.Balance }, car);
        }
        
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return NotFound();//return NoContent();//normal
        }
    }
}
