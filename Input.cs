using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOPArv
{
    public static class Input
        //klass med metoder för felhantering vid inmatning av användaren.
    {
        public static string ReadInput()
        {
            bool valid = true;
            string input;
            do
            {
                input = Console.ReadLine().ToLower();
                if (input != null) { valid = true; }
                else { Console.WriteLine("Invalid output\n\n Try again:"); }
            } while (!valid);
            return input;
        }
        public static int NumInput()
        {
            bool valid = false;
            int numInput = 0;
            // loop för felhantering, man vill ju förmodligen försöka igen om man skrev något fel
            do
            {
                string input = Console.ReadLine();
                try
                {
                    numInput = Int32.Parse(input);
                    valid = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input! \n\n Try again:");
                }
            } while (!valid);

            return numInput;
        }
    }
}
