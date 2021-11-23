using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class TeamPrinciple : Person
    {
        public TeamPrinciple(TeamPrincipleSalaryCalculator TPsalary, string name, int age, string gender, string education, int yearsofExperience) : base(name, age, gender)
        {
            Education = education;
            YearsOfExperience = yearsofExperience;
            tpSalary = TPsalary;
        }
        public string Education { get; }
        public int YearsOfExperience { get; }
        private ITeamPrincipleSalaryCalculator tpSalary { get; set; }

        public override string Identify(Person person)
        {
            return base.Identify(person);
        }
        public int GetSalary()
        {
            return tpSalary.CalculateSTPSalary(YearsOfExperience);
        }
    }
}
