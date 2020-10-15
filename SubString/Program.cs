using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sumString = "interpolation";
            Console.WriteLine($"{sumString.Length}");
            string newString = sumString.Substring(0, 5);
            Console.WriteLine(newString);
            string polationString = sumString.Substring(5, 8);
            Console.WriteLine(polationString); 
        }
    }
}
