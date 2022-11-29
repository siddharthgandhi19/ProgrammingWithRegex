using System;
namespace ProgrammingWithRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programming With Regex Problem Statements");
            Console.WriteLine("Select Below Mention Options");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1. ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:    
                        PostalCode code = new PostalCode();
                        string opt = Convert.ToString(Console.ReadLine());
                        code.TestPinCode(opt);
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}