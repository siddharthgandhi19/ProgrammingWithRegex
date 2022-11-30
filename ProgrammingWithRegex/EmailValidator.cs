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
        const string EMAIL_REGEX = "^[a-zA-Z]{3,}$";
        public void VerifyEmail(string input)
        {

            if (Regex.IsMatch(input, EMAIL_REGEX))
                Console.WriteLine("Email Matches");
            else
                Console.WriteLine("Email Regex Failed");
        }
    }
}
