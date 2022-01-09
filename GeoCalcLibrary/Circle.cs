using System;

namespace GeoCalcLibrary
{
    public class Circle
    {
        public double Radius { get; set;}


        public double Area(double radius)
        {
            double area = Math.PI*Math.Pow(radius, 2);
            return Math.Round(area, 2);
        }

        public void CircleArea()
        {
            double cirArea = 0;
            bool canConvert;
             //do while loop to ensure a double as an answer
            Console.Clear();
            do
            {
                Console.Write("Please enter the radius of the circle: ");
                string ans = Console.ReadLine();
                //check if answer is a double
                canConvert = double.TryParse(ans, out double rad);
                if (canConvert != true)
                {
                    Console.WriteLine("Sorry, try again. This time type a number like 8 or 5.2. The calculation works with any measurement unit (feet, meters, etc), so don't worry about that!");
                }
                else if (canConvert == true)
                {
                    Radius = Convert.ToDouble(ans);
                    cirArea = Area(Radius);
                }
            } while (canConvert != true);

            Console.WriteLine($"The area of your circle is {cirArea} (your measurement of choice) squared.");
        }
    }
}