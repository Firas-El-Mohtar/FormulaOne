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
    public partial class Monaco : Form
    {
        MonacoBusniessLogic monacoBL = new MonacoBusniessLogic();
        public Monaco(Team team)
        {
            monacoBL.MyTeam = team;
            DialogResult result = SettingUpMonaco();
            if (result == DialogResult.OK)
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
            BarrierLeft.Top += monacoBL.Gravity;
            BarrierRight.Top += monacoBL.Gravity;
            MiddleBarrier.Top += monacoBL.Gravity;
            Score.Text = "Score: " + monacoBL.ScoreValue; 
            if(Math.Abs(MiddleBarrier.Top - BarrierLeft.Top) <= monacoBL.Range)
            {
                MiddleBarrier.Top -= monacoBL.Range;
            }

            if(BarrierLeft.Top >= 900)
            {
                BarrierLeft.Top = 12;
                monacoBL.ScoreValue++;
            }
            if (BarrierRight.Bottom >= 905)
            {
                BarrierRight.Top = 10;
                monacoBL.ScoreValue++;
            }

            if(MiddleBarrier.Top >= 910)
            {
                MiddleBarrier.Top = -30;
                monacoBL.ScoreValue++;
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


        private DialogResult SettingUpMonaco()
        {

            return MessageBox.Show(monacoBL.SettingUpMonacoText(), Constants.SettingUpMonaco);
        }
        private DialogResult LastDialog()
        {
            
            DialogResult result = MessageBox.Show(monacoBL.LastDialogText(), Constants.EndOfRace);

            return result;
        }
    }
}
