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


    }
}