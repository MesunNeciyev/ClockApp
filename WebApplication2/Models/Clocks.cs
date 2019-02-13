using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Clock
    {
        public int ClockId { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public int Price { get; set; }

        public int  RentPriceForHours { get; set; }

        public int Amount { get; set; }
    }
}
