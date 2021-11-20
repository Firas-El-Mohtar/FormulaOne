using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public class InitialScreenSetups : IInitialScreenSetups, Interfaces.IRedBullRingSetup
    {
        public Team Myteam { get; set; }
        public Driver Mydriver { get; set; }
        public Car.Car Mycar { get; set; }

        IAccount account;
        public string CarSetup()
        {
            return Constants.RedBullRingSettingUpCar;
        }

        public string ConfiguringFlightPath()
        {
            return Constants.ClearOutSky;
        }

        public Team MyTeam(Car.Car MyCar, Driver MyDriver, TeamPrinciple MyTeamPrinciple, string TeamName)
        {
            Myteam = new Team(MyCar, MyDriver, MyTeamPrinciple, TeamName);
            return Myteam;
        }

        public string PlaceFloatingBarriers()
        {
            return Constants.PlaceBarriers;
        }

        public Car.Car SetupCar(string chassis, string engine, string kit)
        {
            return new Car.Car(chassis, engine, kit);
        }

        public Driver SetupDriver(string name, int age, string gender, int championshipswon, string nickname)
        {
            return new Driver(new DriverSalary(), name, age, gender, championshipswon, nickname);
        }

        public TeamPrinciple SetupTeamPrinciple(string name, int age, string gender, string education, int yearsOE)
        {
            return new TeamPrinciple(new TeamPrincipleSalaryCalculator(), name, age, gender, education, yearsOE);
        }
        private void SetAccount(IAccount Account)
        {
            account = Account;
        }

        public string TheWholeSetup()
        {
            StringBuilder message = new StringBuilder();

            message.Append(CarSetup());
            message.Append(Myteam.MyDriver.GetDriverNumber().ToString());
            message.Append(" should be ready");
            message.AppendLine();
            message.Append(PlaceFloatingBarriers());
            message.AppendLine();
            message.Append(ConfiguringFlightPath());
            message.AppendLine();
            message.Append(Constants.GivenEmail);
            message.AppendLine();
            SetAccount(Factory.CreateDriverAccount());
            message.Append(account.CreateEmail(Myteam.MyDriver));
            message.AppendLine();
            SetAccount(Factory.CreateTeamPrincipleAccout());
            message.Append(account.CreateEmail(Myteam.MyTeamPrinciple));
            return message.ToString();
        }
    }

}
