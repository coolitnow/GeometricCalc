using System;

namespace GeoCalcLibrary
{
    public class Triangle
    {
        public double BaseMeasure;
        public double Height;

        public double TriangleArea(double baseMeasurement, double height)
        {
            return baseMeasurement * height * .5;
        }

        public void TrianglePrompt()
        {
            bool canConvert;
            Console.Clear();

            //do while loop to ensure a double as an answer
            do{
            Console.WriteLine("Please enter the base of the triangle: ");
            string ans = Console.ReadLine();

            canConvert = double.TryParse(ans, out double len);

                if (canConvert != true)
                {
                     Console.WriteLine("Sorry, try again. This time type a number like 8 or 5.2. The calculation works with any measurement unit (feet, meters, etc), so don't worry about that!");
                }
                else if (canConvert == true)
                {
                    BaseMeasure = Convert.ToDouble(ans);
                }

            }while(canConvert != true);

            do{
            Console.WriteLine("Please enter the height of the triangle: ");
            string ans = Console.ReadLine();

            canConvert = double.TryParse(ans, out double len);

            if (canConvert != true)
                {
                     Console.WriteLine("Sorry, try again. This time type a number like 8 or 5.2. The calculation works with any measurement unit (feet, meters, etc), so don't worry about that!");
                }
                else if (canConvert == true)
                {
                    Height = Convert.ToDouble(ans);
                }

            }while(canConvert != true);

            double area = TriangleArea(BaseMeasure, Height);

            Console.WriteLine($"The area of your triangle is {area} square (chosen unit of measurement)."); 

        }

    }
}