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
    public partial class InitialScreen : Form, Interfaces.IRedBullRingSetup
    {
        private Team MyTeam;
        Account account;
        public InitialScreen()
        {
            InitializeComponent();
            InitializeDropBoxes();
            string Teal = CustomColors.ColorList[Constants.Teal];
            string Red = CustomColors.ColorList[Constants.Red];
            // Control all the Comboboxes that Begin with the string CB
            var comboBox = Controls
                .OfType<ComboBox>()
                .Where(x => x.Name.StartsWith("CB"));
            // Loop through them and set the color of the foreground text to Teal
            foreach(var cb in comboBox)
            {
                cb.ForeColor = SetViewColor(Teal);
            }
            AttentionText.ForeColor = SetViewColor(Red);

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

        private void Done_Click(object sender, EventArgs e)
        {
            // Setting up the driver from the collected Data
            People.Driver MyDriver = SetUpDriver();
            
            // Setting Up the Team Principle 
            People.TeamPrinciple  MyTeamPrinciple = SetUpTeamPrinciple();
            // Building the car 
            Car.Car MyCar = SetUpCar();
            // Finally assembling the team and getting ready for the grand Prix
            MyTeam = new Team(MyCar, MyDriver, MyTeamPrinciple, TeamName.Text);

   
            DialogResult result = TransitionalScreen();

            if(result == DialogResult.OK)
            {
                RedBullRing redbullring = new RedBullRing(MyTeam);
                redbullring.Show();
                Hide();
            }
            else
            {
                Close();
            }
            

        }
        private People.Driver SetUpDriver()
        {
            string Name = DriverNameText.Text;
            People.Gender PrivateGender = (People.Gender)CBDriverGender.SelectedIndex;
            string Gender = PrivateGender.ToString();
            int age = int.Parse(DriverAgeText.Text);
            int championshipswon = int.Parse(DriverChamp.Text);
            string Nickname = DriverNickname.Text;

            return new People.Driver(new People.DriverSalary(), Name, age, Gender, championshipswon, Nickname);
        }

        private People.TeamPrinciple SetUpTeamPrinciple()
        {
            string tname = TeamPricncipleName.Text;
            People.Gender PrivateTeampGender = (People.Gender)CBTeamPrincipleGender.SelectedIndex;
            string tgender = PrivateTeampGender.ToString();
            int tage = int.Parse(TeamPrincipleAge.Text);
            string education = TeamPrincipleEducation.Text;
            int yearsOE = int.Parse(TeamPrincipleYOE.Text);

            return new People.TeamPrinciple(new People.TeamPrincipleSalaryCalculator(),tname, tage, tgender, education, yearsOE);
        }
            
        private Car.Car SetUpCar()
        {
            Car.Chassis PrivateChassis = (Car.Chassis)CBCarChassis.SelectedIndex;
            string StringChassis = PrivateChassis.ToString();
            Car.Engine PrivateEngine = (Car.Engine)CBCarEngine.SelectedIndex;
            string StringEngine = PrivateEngine.ToString();
            Car.BodyKit PrivateKit = (Car.BodyKit)CBABodyKit.SelectedIndex;
            string StringKit = PrivateKit.ToString();

           return new Car.Car(StringChassis, StringEngine, StringKit);
        }

        public string ConfiguringFlightPath()
        {
            return Constants.ClearOutSky;
        }

        public string PlaceFloatingBarriers()
        {
            return Constants.PlaceBarriers;
        }

        public string CarSetup()
        {
            return Constants.RedBullRingSettingUpCar;
        }
        private DialogResult TransitionalScreen()
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

            DialogResult result = MessageBox.Show(message.ToString(), Constants.RedBullRingSetupTitle);
            
            return result;
        }

        private void SetAccount(Account Account)
        {
            account = Account;
        }
        
    }
}
