using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingWebApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public CarType Ctype { get; set; }
    }

    public enum CarType
    {
        Passenger, Truck, Bus, Motocycle
    }
}
