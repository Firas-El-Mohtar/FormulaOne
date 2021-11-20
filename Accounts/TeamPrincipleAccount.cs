using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public class TeamPrincipleAccount : Account
    {
        public override string CreateEmail(People.Person person)
        {
            return $"{person.Name.Substring(0,1)}.Managment.FormulaOne@gmail.com";
        }
    }
}
