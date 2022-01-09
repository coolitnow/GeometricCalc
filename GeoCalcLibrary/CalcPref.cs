using System;

namespace GeoCalcLibrary
{
    public class CalcPref
    {
        public bool contCalc()
        {
            Console.WriteLine("Do you have more shape calculations to perform? Y)es or N)o");
            string ans = Console.ReadLine().ToLower();

            while (ans != "y" && ans != "n")
            {
                Console.WriteLine("I'm sorry. Please type 'Y' if you would like to continue calculating or 'N' if you would like to exit the program.");
                ans = Console.ReadLine().ToLower();
            }
            if (ans == "y")
            {
                Console.Clear();
                return true;
            }
            else if (ans == "n")
            {
                Console.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}