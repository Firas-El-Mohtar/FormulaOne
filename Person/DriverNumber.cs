using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class DriverNumber
    {
        private static DriverNumber instance;
        private int driverNumber;
        private DriverNumber() 
        {
            Random random = new Random();
            driverNumber = random.Next(1, 100);
        }
        public static DriverNumber GetInstance()
        {
            if(instance == null)
            {
                instance = new DriverNumber();
            }
            return instance;
        }
        public int GetDriverNumber()
        {
            return driverNumber;
        }
    }
}
