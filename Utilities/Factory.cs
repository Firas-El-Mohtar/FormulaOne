using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public static class Factory
    {
        public static IAccount CreateDriverAccount()
        {
            return new DriverAccount();
        }
        public static IAccount CreateTeamPrincipleAccout()
        {
            return new TeamPrincipleAccount();
        }

    }
}
