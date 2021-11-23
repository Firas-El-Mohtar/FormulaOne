using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public class MonacoBusniessLogic : IMonacoSetup, IMonacoPodiumRitual
    {
        private int points;
        public int Gravity { get; set; }
        public int ScoreValue { get; set; }

        public int Range { get; }
        public Team MyTeam { get; set; }
        public MonacoBusniessLogic()
        {
            Range = 100;
            Gravity = 17;
            ScoreValue = 0;
        }
        public string AssignPoints()
        {
            if (ScoreValue < 5)
            {
                points = 10;
                MyTeam.Points += 10;
            }
            else if (ScoreValue < 10)
            {
                points = 20;
                MyTeam.Points += 20;
            }
            else
            {
                points = 40;
                MyTeam.Points += 40;
            }

            StringBuilder assignPoints = new StringBuilder();
            assignPoints.Append(ExtensionMethods.ExtensionMethods.ReturnNameWithNickname(MyTeam.MyDriver.Name, MyTeam.MyDriver.Nickname));
            assignPoints.Append(Constants.HasJustAddedText);
            assignPoints.Append(points);
            assignPoints.Append(" Points To ");
            assignPoints.Append(MyTeam.Name);
            assignPoints.Append(" Making the total Points = ");
            assignPoints.Append(MyTeam.Points);
            return assignPoints.ToString();
           
        }

        public string CarSetup()
        {
            return Constants.HighDownForce;
        }

        public string DiveIntoPool()
        {
            StringBuilder message = new StringBuilder();
            message.Append(ExtensionMethods.ExtensionMethods.ReturnNameWithNickname(MyTeam.MyDriver.Name, MyTeam.MyDriver.Nickname));
            message.Append(Constants.DriverPool);
            return message.ToString();
        }

        public string TrackBeingPaved()
        {
            return Constants.ChangingingTarmac;
        }

        public string YachtsDocking()
        {
            return Constants.RichMonégasques;
        }
        public string LastDialogText()
        {
            StringBuilder message = new StringBuilder();
            message.Append(AssignPoints());
            message.AppendLine();
            message.Append(DiveIntoPool());
            return message.ToString();
        }
        public string SettingUpMonacoText()
        {
            StringBuilder message = new StringBuilder();
            message.Append(TrackBeingPaved());
            message.Append(CarSetup());
            message.Append(YachtsDocking());
            return message.ToString();
        }
    }
}
