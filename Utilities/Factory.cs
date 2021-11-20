using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public static class Factory
    {
        public static InitialScreenSetups CreateInitialScreenSetup()
        {
            return new InitialScreenSetups();
        }
        public static DriverAccount CreateDriverAccount()
        {
            return new DriverAccount();
        }
        public static TeamPrincipleAccount CreateTeamPrincipleAccout()
        {
            return new TeamPrincipleAccount();
        }

    }
}
