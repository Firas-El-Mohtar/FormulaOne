using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    interface IInitialScreenSetups
    {
        People.Driver SetupDriver(string name, int age, string gender, int championshipswon, string nickname);
        People.TeamPrinciple SetupTeamPrinciple(string name, int age, string gender, string education, int yearsOE);
        Car.Car SetupCar(string chassis, string engine, string kit);
        Team MyTeam(Car.Car MyCar, People.Driver MyDriver, People.TeamPrinciple MyTeamPrinciple, string TeamName);
        
    }
}
