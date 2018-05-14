using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkingWebApp.Controllers
{
    [Produces("application/json")]
    public class ParkingController : ControllerBase
    {
        // GET: api/Parking
        //Return number of the free parking spaces
        [Route("api/Parking")]
        [Route("api/Parking/Free")]
        [HttpGet]
        public int Free()
        {
            return 10;
        }

        //Return number of the busy parking spaces
        [Route("api/Parking/Busy")]
        [HttpGet]
        public int Busy()
        {
            return 20;
        }

        //Return total parking profit
        [Route("api/Parking/Profit")]
        [HttpGet]
        public decimal TotalProfit()
        {
            return 30.0M;
        }

    }
}
