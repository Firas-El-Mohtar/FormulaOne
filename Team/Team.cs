using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public class Team
    {
        public Team(Car.Car car, People.Driver driver, People.TeamPrinciple tp, string name)
        {
            MyCar = car;
            MyDriver = driver;
            MyTeamPrinciple = tp;
            Name = name;
        }
        public Team(People.Driver driver, People.TeamPrinciple tp, string name)
        {
            MyDriver = driver;
            MyTeamPrinciple = tp;
            Name = name;
            string Chassis = nameof(Car.Chassis.Ferrari);
            string Engine = nameof(Car.Engine.Ferrari);
            string Aero = nameof(Car.BodyKit.Ferrari);
            Car.Car car = new Car.Car(Chassis, Engine, Aero);
            MyCar = car;
            
        }
        public string Name { get; }
        public Car.Car MyCar { get; }
        public People.Driver MyDriver { get; }
        public People.TeamPrinciple MyTeamPrinciple { get; }
        public int Points { get; set; }
    }
}
