using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public class InitialScreenSetups : IRedBullRingSetup, IInitialScreenSetups
    {
        public Team MyTeam { get; set; }
        public Driver MyDriver { get; set; }
        public Car.Car MyCar { get; set; }
        public TeamPrinciple tp { get; set; }

        IAccount account;
        public string CarSetup()
        {
            return Constants.RedBullRingSettingUpCar;
        }

        public string ConfiguringFlightPath()
        {
            return Constants.ClearOutSky;
        }

        public void SettingMyTeam(string TeamName)
        {
            MyTeam = new Team(MyCar, MyDriver, tp, TeamName);
        }

        public string PlaceFloatingBarriers()
        {
            return Constants.PlaceBarriers;
        }

        public void SetupCar(string chassis, string engine, string kit)
        {
            MyCar = new Car.Car(chassis, engine, kit);
        }

        public void SetupDriver(string name, int age, string gender, int championshipswon, string nickname)
        {
            MyDriver = new Driver(new DriverSalary(), name, age, gender, championshipswon, nickname);
        }

        public void SetupTeamPrinciple(string name, int age, string gender, string education, int yearsOE)
        {
            tp = new TeamPrinciple(new TeamPrincipleSalaryCalculator(), name, age, gender, education, yearsOE);
        }
        private void SetAccount(IAccount Account)
        {
            account = Account;
        }

        public string TheWholeSetup()
        {
            StringBuilder message = new StringBuilder();

            message.Append(CarSetup());
            message.Append(MyTeam.MyDriver.GetDriverNumber().ToString());
            message.Append(" should be ready");
            message.AppendLine();
            message.Append(PlaceFloatingBarriers());
            message.AppendLine();
            message.Append(ConfiguringFlightPath());
            message.AppendLine();
            message.Append(Constants.GivenEmail);
            message.AppendLine();
            SetAccount(Factory.CreateDriverAccount());
            message.Append(account.CreateEmail(MyTeam.MyDriver));
            message.AppendLine();
            SetAccount(Factory.CreateTeamPrincipleAccout());
            message.Append(account.CreateEmail(MyTeam.MyTeamPrinciple));
            return message.ToString();
        }
    }

}
