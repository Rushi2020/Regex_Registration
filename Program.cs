//  User registration using regex

using System;

namespace Regex_Registration
{
    class program
    {
        static void Main (string[] args)
        {
            UserRegPattern userRegPattern = new UserRegPattern();


            //vhecking firstname
            string[] checkFirstName = { "Rushi","ram","PREM","rOHAN" };
            userRegPattern.ValidateFirstName(checkFirstName);

            //checking lastname
            string[] checkLastName = { "Patil","PATIL","kOLI" };
            userRegPattern.ValidateFirstName(checkLastName);


        }
    }
}
