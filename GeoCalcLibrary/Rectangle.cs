using System;

namespace GeoCalcLibrary
{
    public class Rectangle
    {
        public double Length;
        public double Width;
        public double Area;

        public double RectArea(double width, double length)
        {
            return length*width;
        }

        public void RectAreaPrompt()
        {
            bool canConvert;
            //do while loop to ensure a double as an answer
            Console.Clear();
            do
            {
                Console.Write("Please enter the width of the rectangle: ");
                string ans = Console.ReadLine();
                //check if answer is a double
                canConvert = double.TryParse(ans, out double wid);
                if (canConvert != true)
                {
                    Console.WriteLine("Sorry, try again. This time type a number like 8 or 5.2. The calculation works with any measurement unit (feet, meters, etc), so don't worry about that!");
                }
                else if (canConvert == true)
                {
                    Width = Convert.ToDouble(ans);
                }
            } while (canConvert != true);

            do
            {
                Console.Write("Please enter the length of the rectangle: ");
                string ans = Console.ReadLine();
                //check if answer is a double
                canConvert = double.TryParse(ans, out double len);
                if (canConvert != true)
                {
                    Console.WriteLine("Sorry, try again. This time type a number like 8 or 5.2. The calculation works with any measurement unit (feet, meters, etc), so don't worry about that!");
                }
                else if (canConvert == true)
                {
                    Length = Convert.ToDouble(ans);
                }
            } while (canConvert != true);
            
            Area = RectArea(Width, Length);

            Console.WriteLine($"The area of your rectangle is {Area} square (chosen unit of measurement).");
        }
    }
}