using System;
using System.Threading;
using GeoCalcLibrary;

namespace GeoCalcUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Geometry Calculator! \nCan I calculate every geometric problem??");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...No.");
            Thread.Sleep(1000);
            Console.WriteLine("but I CAN help you calculate a few things!");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Let's get started");
            Thread.Sleep(1000);

            //a bool to keep the while loop open, and also as a tool to close it
            bool calculate = true;
            
            while (calculate == true)
            {
                 Console.WriteLine("What would you like to calculate?\na) Area of a Circle\nb) Area of a Rectangle\nd) Quit");
                string shape2Calc = Console.ReadLine().ToLower();

                while (shape2Calc != "a" && shape2Calc != "b" && shape2Calc != "d")
                {
                    Console.WriteLine("I'm sorry, please choose the corresponding letter with your desired geometric calculation:\na) Find the area of a Circle\nb) Area of a Rectangle\nd) Quit");
                    shape2Calc = Console.ReadLine().ToLower();
                }
                
                bool canConvert;

                if (shape2Calc == "a")
                {
                    //add ability to calculate by radius or diameter
                    //insantiate new circle
                    Circle crcl = new Circle();
                    
                    crcl.CircleArea();
                    
                }
                else if (shape2Calc == "d")
                {
                    calculate = false;
                }
                
                 
            }

            Console.WriteLine("Thanks for calculating today! See you around the area, I'm sure");


        }
    }
}
