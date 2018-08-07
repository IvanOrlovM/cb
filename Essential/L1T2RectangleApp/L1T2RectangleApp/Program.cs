using System;
using static System.Convert;

namespace L1T2RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Height: ");

            var side1 = ToDouble
                (Console.ReadLine());

            Console.WriteLine("width: ");

            var side2 = ToDouble
                (Console.ReadLine());

            var rectangle = new Rectangle(side1, side2);
           // double area = rectangle.AreaCalc();
           // double perimeter = rectangle.PerimeterCalc();

            Console.WriteLine("Perimeter = {0}, Area= {1}", rectangle.Perimeter, rectangle.Area);

            Console.WriteLine("To exit - press any key");

            Console.ReadKey();
        }
    }
}
