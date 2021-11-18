using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class TeamPrinciple : Person
    {
        public TeamPrinciple(string name, int age, string gender, string education, int yearsofExperience) : base(name, age, gender)
        {
            Education = education;
            YearsOfExperience = yearsofExperience;
        }
        public string Education { get; }
        public int YearsOfExperience { get; }
    }
}
