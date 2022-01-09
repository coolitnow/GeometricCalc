using System;
using System.Threading;
using GeoCalcLibrary;

namespace GeoCalcUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Square sqr = new Square
            // {
            //     Length = 12,
            //     Width = 4
            // };
            
            // Console.WriteLine($"{sqr.Length} is the Length and {sqr.Width} is the width");

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

            bool calculate = true;
            

            while (calculate == true)
            {
                 Console.WriteLine("What would you like to calculate?\na) Area of a Circle\nd) Quit");
                string shape2Calc = Console.ReadLine().ToLower();

                while (shape2Calc != "a" && shape2Calc != "d")
                {
                    Console.WriteLine("I'm sorry, please choose the corresponding letter with your desired geometric calculation:\na) Find the area of a Circle\nd) Quit");
                    shape2Calc = Console.ReadLine().ToLower();
                }
                
                bool canConvert;

                if (shape2Calc == "a")
                {
                    //insantiate new circle
                    Circle crcl = new Circle();
                    //have to set the Diameter here in order to change it in the Do loop
                    
                    
                    do
                    {
                        Console.Write("Please enter the radius of the circle in inches: ");
                        string ans = Console.ReadLine();
                        //check if answer is a double
                        canConvert = double.TryParse(ans, out double radius);
                        if (canConvert != true)
                        {
                            Console.WriteLine("Sorry, try again. This time type a number like 8 or 5.2.");
                        }
                        else if (canConvert == true)
                        {
                            crcl.Radius = Convert.ToDouble(ans);
                        }
                        

                    } while (canConvert != true);

                    
                }
                else if (shape2Calc == "d")
                {
                    calculate = false;
                }
                
                 
            }

            Console.WriteLine("Thanks for calculating today! See around the area, I'm sure");


        }
    }
}
