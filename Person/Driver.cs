using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Driver : Person
    {
        public Driver(string name, int age, string gender, int championshipsWon, string nickName) : base(name, age, gender)
        {
            ChampionshipsWon = championshipsWon;
            Nickname = nickName;
        }
        public Driver(string name, int age, string gender, string nickName):base(name, age, gender)
        {
            Nickname = nickName;
            ChampionshipsWon = 0;
        }

        public int ChampionshipsWon { get; }
        public string Nickname { get; }

        public override string Identify(Person person)
        {
            return ExtensionMethods.ExtensionMethods.ReturnNameWithNickname(person.Name, Nickname);
        }
    }
}
