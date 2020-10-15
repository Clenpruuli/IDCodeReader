using System;

namespace LOGITpe20
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayLOGIT("LOGITPE20");
        }

        public static void DisplayLOGIT(string LOGITpe20)
        {
            string logit = LOGITpe20.Substring(0, 5);
            string pe = LOGITpe20.Substring(5, 2);
            string twenty = LOGITpe20.Substring(7, 2);
            Console.WriteLine($"-->{logit}");
            Console.WriteLine($"-->{pe}");
            Console.WriteLine($"-->{twenty}");
        }
    }
}
