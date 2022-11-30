using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingWithRegex
{
    public class EmailValidator
    {
        const string EMAIL_REGEX = "^[a-zA-Z]{2,}$";
        const string EMAIL_REGEX1 = "^[a-zA-Z]+[@][a-zA-Z]{3,}$";
        const string EMAIL_REGEX3 = "^[a-zA-Z]+[@][a-zA-Z]+[.][a-z]{2,}$";
        const string EMAIL_REGEX4 = "^[a-zA-Z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){1}$";
                                         

        public void VerifyEmail(string input)
        {

            if (Regex.IsMatch(input, EMAIL_REGEX))
                Console.WriteLine("Email Matches");
            else
                Console.WriteLine("Email Regex Failed");
        }
        public void VerifyEmail2(string input)
        {

            if (Regex.IsMatch(input, EMAIL_REGEX1))
                Console.WriteLine("Email Matches");
            else
                Console.WriteLine("Email Regex Failed");
        }
        public void VerifyEmail3(string input)
        {

            if (Regex.IsMatch(input, EMAIL_REGEX3))
                Console.WriteLine("Email Matches");
            else
                Console.WriteLine("Email Regex Failed");
        }
        public void VerifyEmai4(string input)
        {

            if (Regex.IsMatch(input, EMAIL_REGEX4))
                Console.WriteLine("Email Matches");
            else
                Console.WriteLine("Email Regex Failed");
        }
    }
}
