using System;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Height: ");
            string height = Console.ReadLine();

            int.TryParse(height, out var value);

            Console.Write("Enter Width: ");
            string width = Console.ReadLine();

            int.TryParse(width, out var value1);

            Console.Clear();
            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
