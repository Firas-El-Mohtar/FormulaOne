using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne
{
    public abstract class Account
    {
        public virtual string CreateEmail(People.Person person) 
        { 
            return $"{person.Name}.FormulaOne@gmail.com"; 
        }
    }
}
