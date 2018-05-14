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
    //[Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        // GET: api/Transactions/Log
        //Return Transactions.log
        [Route("api/Transactios/Log")]
        [HttpGet]
        public IEnumerable<string> Log()
        {
            return new string[] {};
        }

        // GET: api/Transactions/LastMin
        //Return Transactions for the last minute
        [Route("api/Transactios/LastMin")]
        [HttpGet]
        public IEnumerable<Transaction> LastMin()
        {
            return new Transaction[] { };
        }


        // GET: api/Transactions/5
        //Return Transactions for the last minute for the same car
        [Route("api/Transactios/LastMinCar")]
        [HttpGet("{id}")]
        public IEnumerable<Transaction> LastMinCar(int id)
        {
            return new Transaction[] { };
        }


        // PUT: api/Transactions/5
        //Put money to car balance
        [Route("api/Transactios")]
        [HttpPut("{id}")]
        public IActionResult PutMoney(int id, [FromBody]decimal value)
        {
            return NotFound();//return NoContent();//normal
        }
    }
}
