using System;

namespace L1T2RectangleApp
{
    class Program
    {
        static void Main()
        {
            var height = ReadLineToDouble("Height: ");
            var width = ReadLineToDouble("Width: ");

            var rectangle = new Rectangle(height, width);

            Console.WriteLine($"Perimeter = {rectangle.Perimeter}, Area= {rectangle.Area}");

            Console.WriteLine("To exit - press any key");

            Console.ReadKey();
        }

        private static double ReadLineToDouble(string s)
        {
            Console.Write(s);
            var inputWidht = Console.ReadLine();

            double value;
            while (!double.TryParse(inputWidht, out value))
            {
                Console.WriteLine("Value is not a number in a valid format.");
                inputWidht = Console.ReadLine();
            }

            return value;
        }
    }
}