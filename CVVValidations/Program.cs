using System;

namespace CVVValidations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your CVV code:");
            string Userinput = Console.ReadLine();
            if (CVVValidations(Userinput))
            {
                Console.WriteLine("Welcome!");
            } else
            {
                Console.WriteLine("Go away!");
            }

        }
        public static bool CVVValidations(string Cvvcode)
        {
            
            if (Cvvcode.Length == 3)
            {
                try
                {
                    Int32.Parse(Cvvcode);
                    return true;

                } catch(Exception error)
                {
                    Console.WriteLine("Failed to parse.");
                    return false;
                }
                
               
            }
            else
            {
                return false;

            }
           
        }
        
    }
}
