using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class TeamPrincipleSalaryCalculator : ITeamPrincipleSalaryCalculator
    {
        public int CalculateSTPSalary(int YOE)
        {
            return (int)(30000 * YOE * 1.1);
        }
    }
}
