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
    public partial class RedBullRing : Form
    {
        //private Team MyTeam;
        RedbullRingLogic rbl;

        public RedBullRing(Team team)
        {
            rbl = new RedbullRingLogic();
            rbl.MyTeam = team;
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Car.Top += rbl.Gravity;
            BarrierBottom.Left -= rbl. BarrierSpeed;
            BarrierTop.Left -= rbl.BarrierSpeed;

            Score.Text = rbl.MyTeam.MyDriver.Name + Constants.Score + rbl.ScoreValue;
            if (BarrierBottom.Left < -50)
            {
                BarrierBottom.Left = 630;
                rbl.ScoreValue++;
            }
            if (BarrierTop.Left < -50)
            {
                BarrierTop.Left = 730;
                rbl.ScoreValue++;
            }
            if (Car.Bounds.IntersectsWith(BarrierBottom.Bounds) ||
                Car.Bounds.IntersectsWith(BarrierTop.Bounds) ||
                Car.Bounds.IntersectsWith(Ground.Bounds) || Car.Top < -25
                )
            {
                EndGame();
            }

            if (rbl.ScoreValue < 100)
            {
                rbl.BarrierSpeed = rbl.ScoreValue + 4 * 2; ;
            }
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                rbl.Gravity = -7;
            }
        }
        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                rbl.Gravity = 7;
            }
        }
        private void EndGame()
        {
            GameTimer.Stop(); 
            Score.Text += Constants.GameOver;
            DialogResult result = OpenDialog();
            if (result == DialogResult.OK)
            {
                Monaco monaco = new Monaco(rbl.MyTeam);
                monaco.Show();
                Hide();
            }
            else
            {
                Close();
            }

        }
        private DialogResult OpenDialog()
        {
            rbl.GiveTeamPoints();
            StringBuilder message = new StringBuilder();
            message.Append(rbl.AssignPoints());
            message.AppendLine();
            message.Append(rbl.RedBullStunt());

            DialogResult result = MessageBox.Show(message.ToString(), Constants.EndOfRace);

            return result;
        }
        
    }
}
