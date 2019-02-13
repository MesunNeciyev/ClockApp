using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public interface IClockRepisotry
    {
        IEnumerable<Clocks> GetAllClocks();

     
    }
}
