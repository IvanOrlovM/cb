using System;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // param
            var length = 5;
            var height = 4;

            WriteLine(length);

            // body
            for (int i = 0; i < height - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < length - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.Write("\n");
            }

            WriteLine(length);

            Console.ReadLine();
        }

        /// <summary>
        /// Write line
        /// </summary>
        /// <param name="length">lenght</param>
        private static void WriteLine(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }
    }
}
