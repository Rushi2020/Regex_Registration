using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_Registration
{
    internal class UserRegPattern
    {
        public static string FirstName = "^[A-Z]{1}[a-zA-Z]{2,}$";

        public void ValidateFirstName(string[] name)
        {
            foreach (string n in name)
            {
                string result = Regex.IsMatch(n, FirstName) ? $"{n} entered is valid" : $"{n} entered is Invalid";

                Console.WriteLine(result);
            }

        }


    }
}
