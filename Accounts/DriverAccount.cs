using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public class DriverAccount : IAccount
    {
        public string CreateEmail(People.Person person)
        {
            return $"{ExtensionMethods.ExtensionMethods.ReturnFirstName(person.Name)}.Driver.FormulaOne@gmail.com";
        }
    }
}
