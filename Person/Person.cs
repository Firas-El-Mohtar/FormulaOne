using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person
    {
        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; }
        public int Age { get; }
        public string Gender { get; }

        public virtual string Identify(Person person)
        {
            return person.Name;
        }
    }
}
