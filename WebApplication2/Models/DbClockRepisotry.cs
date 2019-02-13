using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class DbClockRepisotry : IClockRepisotry
    {

        private AppDbContex _dbcontex;

        public DbClockRepisotry(AppDbContex dbcontex)
        {
            _dbcontex = dbcontex;
        }




        public IEnumerable<Clock> GetAllClocks()
        {
            return _dbcontex.Clocks.OrderBy(c => c.Name);
        }
    }
}
