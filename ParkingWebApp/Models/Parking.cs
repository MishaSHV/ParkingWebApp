using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingWebApp.Models
{
    public class Parking
    {
        public int NumAvailableSpaces { get; set; }
        public int NumOccupiedSpaces{ get; set; }
        public int TotalRevenue { get; set; }
    }
}
