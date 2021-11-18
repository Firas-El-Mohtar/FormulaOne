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
    public partial class RedBullRing : Form, Interfaces.IRedBullRingPodiumRitual
    {

        int BarrierSpeed = 15;
        int Gravity = 7;
        int ScoreValue = 0;
        private Team MyTeam;

        public RedBullRing(Team team)
        {
            MyTeam = team;
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Car.Top += Gravity;
            BarrierBottom.Left -= BarrierSpeed;
            BarrierTop.Left -= BarrierSpeed;

            Score.Text = MyTeam.MyDriver.Name + Constants.Score + ScoreValue;
            if (BarrierBottom.Left < -50)
            {
                BarrierBottom.Left = 630;
                ScoreValue++;
            }
            if (BarrierTop.Left < -50)
            {
                BarrierTop.Left = 730;
                ScoreValue++;
            }
            if (Car.Bounds.IntersectsWith(BarrierBottom.Bounds) ||
                Car.Bounds.IntersectsWith(BarrierTop.Bounds) ||
                Car.Bounds.IntersectsWith(Ground.Bounds) || Car.Top < -25
                )
            {
                EndGame();
            }

            if (ScoreValue < 100)
            {
                BarrierSpeed = ScoreValue + 4 * 2; ;
            }
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                Gravity = -7;
            }
        }
        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = 7;
            }
        }
        private void EndGame()
        {
            GameTimer.Stop(); 
            Score.Text += Constants.GameOver;
            DialogResult result = OpenDialog();
            if (result == DialogResult.OK)
            {
                Monaco monaco = new Monaco(MyTeam);
                monaco.Show();
                Hide();
            }
            else
            {
                Close();
            }

        }

        public string RedBullStunt()
        {
            StringBuilder driverDiving = new StringBuilder();
            driverDiving.Append(ExtensionMethods.ExtensionMethods.ReturnNameWithNickname(MyTeam.MyDriver.Name, MyTeam.MyDriver.Nickname));
            driverDiving.Append(Constants.RedBullStuntText);
            return driverDiving.ToString();
        }

        public string AssignPoints()
        {
            // actually assigning the points 
            if(ScoreValue < 10)
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

            StringBuilder assignPoints = new StringBuilder();
            assignPoints.Append(ExtensionMethods.ExtensionMethods.ReturnNameWithNickname(MyTeam.MyDriver.Name, MyTeam.MyDriver.Nickname));
            assignPoints.Append(Constants.HasJustAddedText);
            assignPoints.Append(MyTeam.Points);
            assignPoints.Append(" Points To ");
            assignPoints.Append(MyTeam.Name);

            return assignPoints.ToString();
        }
        private DialogResult OpenDialog()
        {
            StringBuilder message = new StringBuilder();
            message.Append(AssignPoints());
            message.AppendLine();
            message.Append(RedBullStunt());

            DialogResult result = MessageBox.Show(message.ToString(), Constants.EndOfRace);

            return result;
        }

    }
}
