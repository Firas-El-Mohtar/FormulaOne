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
    public partial class InitialScreen : Form
    {
        InitialScreenSetups setup = new InitialScreenSetups();
        public InitialScreen()
        {
            InitializeComponent();
            InitializeDropBoxes();
            // Control all the Comboboxes that Begin with the string CB
            SetupComboBoxes();
          
        }
        private Color SetViewColor(string Color)
        {
            return ExtensionMethods.ExtensionMethods.ReturnColor(Color);
        }

        private void InitializeDropBoxes()
        {
            CBDriverGender.Items.AddRange(Enum.GetNames(typeof(People.Gender)));
            CBTeamPrincipleGender.Items.AddRange(Enum.GetNames(typeof(People.Gender)));
            CBCarChassis.Items.AddRange(Enum.GetNames(typeof(Car.Chassis)));
            CBCarEngine.Items.AddRange(Enum.GetNames(typeof(Car.Engine)));
            CBABodyKit.Items.AddRange(Enum.GetNames(typeof(Car.BodyKit)));
        }
        private void SetupComboBoxes()
        {
            string Teal = CustomColors.ColorList[Constants.Teal];
            string Red = CustomColors.ColorList[Constants.Red];
            var comboBox = Controls
              .OfType<ComboBox>()
              .Where(x => x.Name.StartsWith("CB"));
            // Loop through them and set the color of the foreground text to Teal
            foreach (var cb in comboBox)
            {
                cb.ForeColor = SetViewColor(Teal);
            }
            AttentionText.ForeColor = SetViewColor(Red);

        }
        private void Done_Click(object sender, EventArgs e)
        {
            BuildMyTeam();
            DialogResult result = TransitionalScreen();

            if (result == DialogResult.OK)
            {
                RedBullRing redbullring = new RedBullRing(setup.MyTeam);
                redbullring.Show();
                Hide();
            }
            else
            {
                Close();
            }       

        }
        private void BuildMyTeam()
        {
            //My Team is is build inside the InitialScreenSetup
            SetUpDriver();
            SetUpTeamPrinciple();
            SetUpCar();
            setup.SettingMyTeam(TeamName.Text);
        }

     
        private DialogResult TransitionalScreen()
        {
           
            DialogResult result = MessageBox.Show(setup.TheWholeSetup(), Constants.RedBullRingSetupTitle);
            
            return result;
        }


        private void SetUpDriver()
        {
            string Name = DriverNameText.Text;
            People.Gender PrivateGender = (People.Gender)CBDriverGender.SelectedIndex;
            string Gender = PrivateGender.ToString();
            int age = int.Parse(DriverAgeText.Text);
            int championshipswon = int.Parse(DriverChamp.Text);
            string Nickname = DriverNickname.Text;

            setup.SetupDriver(Name, age, Gender, championshipswon, Nickname);
           
        }

        private void SetUpTeamPrinciple()
        {
            string tname = TeamPricncipleName.Text;
            People.Gender PrivateTeampGender = (People.Gender)CBTeamPrincipleGender.SelectedIndex;
            string tgender = PrivateTeampGender.ToString();
            int tage = int.Parse(TeamPrincipleAge.Text);
            string education = TeamPrincipleEducation.Text;
            int yearsOE = int.Parse(TeamPrincipleYOE.Text);
            setup.SetupTeamPrinciple(tname, tage, tgender, education, yearsOE);
           
        }

        private void SetUpCar()
        {
            Car.Chassis PrivateChassis = (Car.Chassis)CBCarChassis.SelectedIndex;
            string StringChassis = PrivateChassis.ToString();
            Car.Engine PrivateEngine = (Car.Engine)CBCarEngine.SelectedIndex;
            string StringEngine = PrivateEngine.ToString();
            Car.BodyKit PrivateKit = (Car.BodyKit)CBABodyKit.SelectedIndex;
            string StringKit = PrivateKit.ToString();
            setup.SetupCar(StringChassis, StringEngine, StringKit);

        }


    }
}
