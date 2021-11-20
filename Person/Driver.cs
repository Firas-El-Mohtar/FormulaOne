using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Driver : Person
    {
        public Driver(DriverSalary driverSalary, string name, int age, string gender, int championshipsWon, string nickName) : base(name, age, gender)
        {
            ChampionshipsWon = championshipsWon;
            Nickname = nickName;
            DriverSalary = driverSalary;
        }
        public Driver(DriverSalary driverSalary, string name, int age, string gender, string nickName):base(name, age, gender)
        {
            Nickname = nickName;
            ChampionshipsWon = 0;
            DriverSalary = driverSalary;
        }

        public int ChampionshipsWon { get; }
        public string Nickname { get; }
        private IDriverSalary DriverSalary { get; set; }
        private DriverNumber driverNumber = DriverNumber.GetInstance();
        public override string Identify(Person person)
        {
            return ExtensionMethods.ExtensionMethods.ReturnNameWithNickname(person.Name, Nickname);
        }
        public int GetSalary()
        {
            return DriverSalary.CalculateDriverSalary(ChampionshipsWon);
        }
        public int GetDriverNumber()
        {
            return driverNumber.GetDriverNumber();
        }

    }
}
