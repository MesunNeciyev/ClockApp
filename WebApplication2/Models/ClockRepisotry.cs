using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ClockRepisotry:IClockRepisotry
    {
        private List<Clock> _clocks;

        public ClockRepisotry()
        {
            if (_clocks == null)
            {
                InitializeClocks();
            }

        }
        private void InitializeClocks()
        {
            _clocks= new List<Clock>
                {
                    new Clock {Name="ClockName1",Brand="BrandName1",Price=100,RentPriceForHours=3,Amount=5},
                    new Clock {Name="ClockName2",Brand="BrandName2",Price=750,RentPriceForHours=30,Amount=10},
                    new Clock {Name="ClockName3",Brand="BrandName3",Price=10000,RentPriceForHours=750,Amount=2},
                    new Clock {Name="ClockName4",Brand="BrandName4",Price=40,RentPriceForHours=1,Amount=150},
                    new Clock {Name="ClockName5",Brand="BrandName5",Price=1500,RentPriceForHours=90,Amount=5},
                    new Clock {Name="ClockName6",Brand="BrandName6",Price=300,RentPriceForHours=60,Amount=12},
            };
            
        }

        public IEnumerable<Clock> GetAllClocks()
        {
            return _clocks;
        }

        
    }
}
