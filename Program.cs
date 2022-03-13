// See https://aka.ms/new-console-template for more information
using System;

namespace Regex_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("user registration");
            UserRegPattern userRegPattern = new UserRegPattern();
            //valid
            userRegPattern.Validate("abc@yahoo.com");
            userRegPattern.Validate("abc-100@yahoo.com");
            userRegPattern.Validate("abc.100@yahoo.com");
            userRegPattern.Validate("abc111@abc.com");
            userRegPattern.Validate("abc-100@abc.net");
            userRegPattern.Validate("abc.100@abc.com.au");
            userRegPattern.Validate("abc@1.com");
            userRegPattern.Validate("abc@gmail.com.com");
            userRegPattern.Validate("abc+100@gmail.com");


            //invalid
            userRegPattern.Validate("abc@.com.my");
            userRegPattern.Validate(".abc@abc.com");
            userRegPattern.Validate("abc@abc@gmail.com");
            userRegPattern.Validate("abc..2002@gmail.com");
            userRegPattern.Validate("abc@gmail.com.1a");
            userRegPattern.Validate("abc@gmail.com.aa.au");

           

        }
    }
}