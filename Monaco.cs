using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaOne
{
    public partial class Monaco : Form, Interfaces.IMonacoSetup, Interfaces.IMonacoPodiumRitual
    {
        int Gravity = 17;
        int ScoreValue = 0;
        const int Range = 200;
        Team MyTeam;
        public Monaco(Team team)
        {
            MyTeam = team;
            DialogResult resilt = SettingUpMonaco();
            if (resilt == DialogResult.OK)
            {
                InitializeComponent();
                Color Blue = ExtensionMethods.ExtensionMethods.ReturnColor(CustomColors.ColorList[Constants.Blue]);
                BarrierLeft.BackColor = Blue;
                BarrierRight.BackColor = Blue;
                MiddleBarrier.BackColor = Blue;
            }
            else
            {
                Close();
            }
        }


        private void GameTimerEvent(object sender, EventArgs e)
        {
            BarrierLeft.Top += Gravity;
            BarrierRight.Top += Gravity;
            MiddleBarrier.Top += Gravity;
            Score.Text = "Score: " + ScoreValue; 
            if(Math.Abs(MiddleBarrier.Top - BarrierLeft.Top) <= Range)
            {
                MiddleBarrier.Top -= Range;
            }

            if(BarrierLeft.Top >= 900)
            {
                BarrierLeft.Top = 12;
                ScoreValue++;
            }
            if (BarrierRight.Bottom >= 905)
            {
                BarrierRight.Top = 10;
                ScoreValue++;
            }

            if(MiddleBarrier.Top >= 910)
            {
                MiddleBarrier.Top = -30;
                ScoreValue++;
            }
            if (Car.Bounds.IntersectsWith(BarrierLeft.Bounds) ||
                Car.Bounds.IntersectsWith(BarrierRight.Bounds) ||
                Car.Bounds.IntersectsWith(RightCurb.Bounds) ||
                Car.Bounds.IntersectsWith(LeftCurb.Bounds) ||
                Car.Bounds.IntersectsWith(MiddleBarrier.Bounds)
                )
            {
                EndGame();
            }
        }

        private void KeyPressedDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                Car.Left -= 20;
            }
            if(e.KeyCode == Keys.Right)
            {
                Car.Left += 20;
            }
            if(e.KeyCode == Keys.Up)
            {
                Car.Top -= 20;
            }
            if(e.KeyCode == Keys.Down)
            {
                Car.Top += 20;
            }
        }
        private void EndGame()
        {
            GameTimer.Stop();
            LastDialog();
        }

        public string YachtsDocking()
        {
            return Constants.RichMonégasques;
        }

        public string TrackBeingPaved()
        {
            return Constants.ChangingingTarmac;
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

        public string AssignPoints()
        {
            // actually assigning the points 
            if (ScoreValue < 5)
            {
                MyTeam.Points += 10;
            }
            else if (ScoreValue < 10)
            {
                MyTeam.Points += 20;
            }
            else
            {
                MyTeam.Points += 40;
            }

            StringBuilder assignPoints = new StringBuilder();
            assignPoints.Append(ExtensionMethods.ExtensionMethods.ReturnNameWithNickname(MyTeam.MyDriver.Name, MyTeam.MyDriver.Nickname));
            assignPoints.Append(Constants.HasJustAddedText);
            assignPoints.Append(MyTeam.Points);
            assignPoints.Append(" Points To ");
            assignPoints.Append(MyTeam.Name);

            return assignPoints.ToString();
        }
        private DialogResult SettingUpMonaco()
        {
            StringBuilder message = new StringBuilder();
            message.Append(TrackBeingPaved());
            message.Append(CarSetup());
            message.Append(YachtsDocking());
            return MessageBox.Show(message.ToString(), Constants.SettingUpMonaco);
        }
        private DialogResult LastDialog()
        {
            StringBuilder message = new StringBuilder();
            message.Append(AssignPoints());
            message.AppendLine();
            message.Append(DiveIntoPool());

            DialogResult result = MessageBox.Show(message.ToString(), Constants.EndOfRace);

            return result;
        }
    }
}
