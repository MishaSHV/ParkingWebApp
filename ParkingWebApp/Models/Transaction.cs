using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingWebApp.Models
{
    public class Transaction
    {
        public DateTime DTtransaction { get; set; }
        public int CarId { get; set; }
        public decimal AmountMoney { get; set; }
    }
}
