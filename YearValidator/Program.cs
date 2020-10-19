using System;
using System.ComponentModel.DataAnnotations;

namespace YearValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth");
            string userInput = Console.ReadLine();

            if(Validate(userInput))
            {

            }
        }

        public static bool Validate(string yearInput)
        {
            if(yearInput.Length == 4)
                try
                {
                    Int32.Parse(yearInput);
                    Console.WriteLine("All good. ");
                    return true;
                } catch(Exception error)
                {
                    Console.WriteLine(error);
                    return false;
                } else
                {
                    Console.WriteLine("Wrong format. ");
                    return false;
                }
        } 
        
        public static void CalculateAge(string yearInput)
        {
            int year = Int32.Parse(yearInput);

            DateTime now = DateTime.Now;
            string currentYear = now.Year.ToString();
            int yearnow = Int32.Parse(currentYear);

            Console.WriteLine($"You are {yearnow} - {year} years old");
        }
        
    }
}
