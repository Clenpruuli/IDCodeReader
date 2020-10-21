using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID code:");
            string usersID = Console.ReadLine();
            if(Validate(usersID))
            {
                Console.WriteLine("Welcome!");
                HelloUser(usersID);
                GetAge(usersID);

            }else
            {
                Console.WriteLine("Wrong format.Try again.");
            }


        }

        public static bool Validate(string idCode)
        {
            if(idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
                
            }
            else
            {
                return false;
            }

            


        }

        public static void HelloUser(string idCode)
        {
            int FirstNum = Int32.Parse(idCode[0].ToString());
            if(FirstNum == 1 || FirstNum == 3 || FirstNum == 5)
            {
                Console.WriteLine("Hello,sir!");

            }else if (FirstNum == 2 || FirstNum == 4 || FirstNum == 6)
            {
                Console.WriteLine("Hello,Madam!");
            }
        }
        public static int GetYear(string IdCode)
        {

            string yearFromCode = IdCode.Substring(1, 2);
            string year;
            if (int.Parse(IdCode[0].ToString()) > 4)
            {
                year = "20" + yearFromCode;
            }
            else
            {
                year = "19" + yearFromCode;
            }

            Console.WriteLine($"You were born in {year}");
            int yearParsed = Int32.Parse(year);

            return yearParsed;

        }

        public static void GetAge(string idCode)
        {
         int yearofbirth = GetYear(idCode);

         DateTime now = DateTime.Now;
         int yearnow = Int32.Parse(now.Year.ToString());
         int age = yearnow - yearofbirth;
         Console.WriteLine($"You are {age} years old.");
         
        }

    }

   
}
