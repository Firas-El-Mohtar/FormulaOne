using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public class RedbullRingLogic: Interfaces.IRedBullRingPodiumRitual
    {
        public RedbullRingLogic()
        {
            BarrierSpeed = 15;
            Gravity = 7;
            ScoreValue = 0;

        }
        public Team MyTeam { get; set; }
        public int BarrierSpeed { get; set; }
        public int Gravity { get; set; }
        public int ScoreValue { get; set; }

        public string AssignPoints()
        {
            StringBuilder assignPoints = new StringBuilder();
            assignPoints.Append(ExtensionMethods.ExtensionMethods.ReturnNameWithNickname(MyTeam.MyDriver.Name, MyTeam.MyDriver.Nickname));
            assignPoints.Append(Constants.HasJustAddedText);
            assignPoints.Append(MyTeam.Points);
            assignPoints.Append(" Points To ");
            assignPoints.Append(MyTeam.Name);
            assignPoints.AppendLine();
            assignPoints.Append(TeamSalaries());
            return assignPoints.ToString();
        }

        public void GiveTeamPoints()
        {
            if (ScoreValue < 10)
            {
                MyTeam.Points = 10;
            }
            else if (ScoreValue < 20)
            {
                MyTeam.Points = 20;
            }
            else
            {
                MyTeam.Points = 40;
            }
        }

        public string RedBullStunt()
        {
            StringBuilder driverDiving = new StringBuilder();
            driverDiving.Append(ExtensionMethods.ExtensionMethods.ReturnNameWithNickname(MyTeam.MyDriver.Name, MyTeam.MyDriver.Nickname));
            driverDiving.Append(Constants.RedBullStuntText);
            return driverDiving.ToString();
        }


        public string TeamSalaries()
        {
            StringBuilder salary = new StringBuilder();
            salary.Append(MyTeam.MyTeamPrinciple.Name);
            salary.Append(Constants.EnjoySalary);
            salary.Append(MyTeam.MyTeamPrinciple.GetSalary());
            salary.AppendLine();
            salary.Append(MyTeam.MyDriver.Name);
            salary.Append(Constants.EnjoySalary);
            salary.Append(MyTeam.MyDriver.GetSalary());
            return salary.ToString();
        }
    }
}
