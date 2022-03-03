﻿using System;
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
        public static string LastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string Email = "^[a-z]{2,}[0-9]{2,}[@][a-z]{2,}[.][a-z]{1,4}$";
        public void ValidateFirstName(string[] name)
        {
            //Firstname validation
            foreach (string n in name)
            {
                string result = Regex.IsMatch(n, FirstName) ? $"{n} entered is valid" : $"{n} entered is Invalid";

                Console.WriteLine(result);
            }


        }
        public void ValidateLastName(string[] name)
        {
            //last name validation
            foreach (string n in name)
            {
                string result = Regex.IsMatch(n, LastName) ? $"{n} entered is valid" : $"{n} entered is Invalid";

                Console.WriteLine(result);
            }
        }

        public void ValidateEmail(string[] name)
        {
            //last name validation
            foreach (string n in name)
            {
                string result = Regex.IsMatch(n, Email) ? $"{n} entered is valid" : $"{n} entered is Invalid";

                Console.WriteLine(result);
            }
        }

    }
}