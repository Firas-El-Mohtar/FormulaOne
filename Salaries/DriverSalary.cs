using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class DriverSalary : IDriverSalary
    {
        public int CalculateDriverSalary(int Championships)
        {
            return Championships * 1000000 + 100000;
        }
    }
}
