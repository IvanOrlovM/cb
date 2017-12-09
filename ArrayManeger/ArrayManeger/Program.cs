using System;
using System.Linq;

namespace ArrayManeger
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("    -= Array maneger =-\n");

                ArrayManager();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nThe end!\nFor the exit press Q\nfor continue press any key.");
            } while (Console.ReadKey().Key != ConsoleKey.Q);
        }

        /// <summary>
        /// Array manager general logic.
        /// </summary>
        private static void ArrayManager()
        {
            var random = new Random();
            int minValue = 0;
            int maxValue = 100;

            int n = UserInput();

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                var next = random.Next(minValue, maxValue);
                array[i] = next;
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\nMax: ");
            Console.WriteLine(array.Max());

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("\nMin: ");
            Console.WriteLine(array.Min());

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nSum: ");
            Console.WriteLine(array.Sum());

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nAverage: ");
            Console.WriteLine(array.Average());

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nArray: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\neven numbers: ");

            foreach (var value in array)
            {
                if (value % 2 == 0)
                {
                    Console.Write(value + " ");
                }
            }
        }

        /// <summary>
        /// Users input.
        /// </summary>
        /// <returns>Returns users inputs number.</returns>
        private static int UserInput()
        {
            int n;
            
            do
            {
                Console.Write("Enter the lenght array: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            return n;
        }
    }
}
