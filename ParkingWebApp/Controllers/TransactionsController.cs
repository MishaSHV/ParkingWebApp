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
    public class TransactionsController : Controller
    {

        // GET: api/Transactions/Log
        //Return Transactions.log
        [Route("api/Transactions/Log")]
        [HttpGet]
        public IEnumerable<string> Log()
        {
            return new string[] {"first transaction", "second transaction" };
        }

        // GET: api/Transactions/LastMin
        //Return Transactions for the last minute
        [Route("api/Transactions/LastMin")]
        [HttpGet]
        public IEnumerable<Transaction> LastMin()
        {
            return new Transaction[] { new Transaction { DTtransaction = DateTime.Now, CarId = 1, AmountMoney = 10.0M } };
        }

        // GET: api/Transactions/5
        //Return Transactions for the last minute for the same car
        [Route("api/Transactions/LastMinCar/")]
        [HttpGet("{id:int}")]
        public IEnumerable<Transaction> LastMinCar(int id)
        {
            return new Transaction[] { new Transaction { DTtransaction = DateTime.Now, CarId = id, AmountMoney = 20.0M } };
        }

        // PUT: api/Transactions/5
        //Put money to car balance
        [Route("api/Transactions/PutMoney")]
        [HttpPut("{id:int}")]
        public IActionResult PutMoney(int id, [FromBody]decimal value)
        {
            //return NotFound();//return NoContent();//normal
            return Ok($"value:{value} id:{id}");
        }
    }
}
