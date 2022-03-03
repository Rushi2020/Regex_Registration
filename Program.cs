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

            //checking mobile number
            string[] checkMobileNo = { "91 8969548565","918695758565","914525412562" };
            userRegPattern.ValidateMobileNo(checkMobileNo);

            //checking mobile number
            string[] checkPassword = { "AsfZ4512", "sdvfg425AA", "dfgRS12L","145214" };
            userRegPattern.ValidatePassword(checkPassword);
        }
    }
}
