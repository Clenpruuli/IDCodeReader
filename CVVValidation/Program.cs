using System;

namespace CVVValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your CVV code:");
            string cvvcode = Console.ReadLine();
            if (cvvcode.Length == 3)
            {
                Console.WriteLine("Welcome!");
                

            }

            else
            {
                Console.WriteLine("Wrong format.Try again.");

            }

            
        }
    }
}  
