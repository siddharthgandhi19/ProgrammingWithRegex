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
                Console.WriteLine(" 1. Check pattern for pincode\n 2. Restrict pincode pattern at begining\n 3. Restrict pincode pattern at End\n 4. Pincode With Space Between\n 5. Email validation start with firstname\n 6. Email validation with @\n 7. Email validation end with (.co)\n 8. Email validation end with (.co.in)\n 9. Email validation with special characters (_,-,.)\n 10. Top Level Domains ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:    
                        PostalCode code = new PostalCode();
                        Console.WriteLine("Enter Pincode");
                        string opt = Convert.ToString(Console.ReadLine());
                        code.TestPinCode(opt);
                        break;
                    case 2:
                        PostalCode code1 = new PostalCode();
                        Console.WriteLine("Enter Pincode");
                        string opt1 = Convert.ToString(Console.ReadLine());
                        code1.TestPinCode2(opt1);
                        break;
                   case 3:
                        PostalCode code2 = new PostalCode();
                        Console.WriteLine("Enter Pincode");
                        string opt2 = Convert.ToString(Console.ReadLine());
                        code2.TestPinCode3(opt2);
                        break;
                    case 4:
                        PostalCode code3 = new PostalCode();
                        Console.WriteLine("Enter Pincode");
                        string opt3 = Convert.ToString(Console.ReadLine());
                        code3.TestPinCode4(opt3);
                        break;
                    case 5:
                        EmailValidator emailValidator = new EmailValidator();
                        Console.WriteLine("Enter Email");
                        string opt4 = Convert.ToString(Console.ReadLine());
                        emailValidator.VerifyEmail(opt4);
                        break;
                    case 6:
                        EmailValidator emailValidator1 = new EmailValidator();
                        Console.WriteLine("Enter Email");
                        string opt5 = Convert.ToString(Console.ReadLine());
                        emailValidator1.VerifyEmail2(opt5);
                        break;
                    case 7:
                        EmailValidator emailValidator2 = new EmailValidator();
                        Console.WriteLine("Enter Email");
                        string opt6 = Convert.ToString(Console.ReadLine());
                        emailValidator2.VerifyEmail3(opt6);
                        break;
                    case 8:
                        EmailValidator emailValidator3 = new EmailValidator();
                        Console.WriteLine("Enter Email");
                        string opt7 = Convert.ToString(Console.ReadLine());
                        emailValidator3.VerifyEmail4(opt7);
                        break;
                    case 9:
                        EmailValidator emailValidator4 = new EmailValidator();
                        Console.WriteLine("Enter Email");
                        string opt8 = Convert.ToString(Console.ReadLine());
                        emailValidator4.VerifyEmail5(opt8);
                        break;
                        case 10:
                        EmailValidator emailValidator5 = new EmailValidator();
                        emailValidator5.VerifyEmail6("abc.xyz@gmail.co.au");
                        emailValidator5.VerifyEmail6("abc.xyz@gmail.co.in");
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