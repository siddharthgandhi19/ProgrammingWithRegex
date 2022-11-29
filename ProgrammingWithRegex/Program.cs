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
                Console.WriteLine(" 1. Check pattern for pincode\n 2. Restrict pincode pattern at begining ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:    
                        PostalCode code = new PostalCode();
                        string opt = Convert.ToString(Console.ReadLine());
                        code.TestPinCode(opt);
                        break;
                    case 2:
                        PostalCode code1 = new PostalCode();
                        string opt1 = Convert.ToString(Console.ReadLine());
                        code1.TestPinCode2(opt1);
                        break;
                        case 3:
                        PostalCode code2 = new PostalCode();
                        string opt2 = Convert.ToString(Console.ReadLine());
                        code2.TestPinCode3(opt2);
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