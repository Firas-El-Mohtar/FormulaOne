using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    interface IInitialScreenSetups
    {
        void SetupDriver(string name, int age, string gender, int championshipswon, string nickname);
        void SetupTeamPrinciple(string name, int age, string gender, string education, int yearsOE);
        void SetupCar(string chassis, string engine, string kit);
        void SettingMyTeam(string TeamName);
        
    }
}
