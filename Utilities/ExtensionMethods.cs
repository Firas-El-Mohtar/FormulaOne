using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static System.Drawing.Color ReturnColor(this string ColorString)
        {
            return System.Drawing.ColorTranslator.FromHtml(ColorString);
        }
        public static string ReturnNameWithNickname(this string name, string nickname)
        {
            int index = 0;
            StringBuilder sb = new StringBuilder();
            StringBuilder secondSB = new StringBuilder();
            sb.Append(name); // sb contains the full string Example: Sergio Perez
            foreach (char a in name) // Loop through the characters of the string Sergio Perez
            {
                if (a == ' ') // if we find a spcae A.K.A the the space between the name Sergio(here it should enter the if statement)Perez
                {
                    break;// we should return from the loop since we figuered out where we should insert the nickname.  
                }
                index++;// we keep looping and adding the index of where the Character is a space
            }
            secondSB.Append(" ");
            secondSB.Append(nickname);
            sb.Insert(index, secondSB);
            return sb.ToString();
        }



    }
}
