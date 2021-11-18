using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {
        public Car(string chassis, string engine, string kit)
        {
            Chassis = chassis;
            Engine = engine;
            Kit = kit;
        }
        public string Chassis { get; }
        public string Engine { get; }
        public string Kit { get; }
    }
}
