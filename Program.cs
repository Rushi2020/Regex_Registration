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
            string[] checkFirstName = { "Rushi" };
            userRegPattern.ValidateFirstName(checkFirstName);

            //checking lastname
            string[] checkLastName = { "Patil" };
            userRegPattern.ValidateLastName(checkLastName);

            //checking lastname
            string[] checkEmail = { "xyz@gmail.com","xyz@bl.com","abc155@bl.in" , "xyz11@bl.com", "abc+22@abc.com","a12@xyz.in","asdf123@gmail.com" };
            userRegPattern.ValidateEmail(checkEmail);

        }
    }
}
