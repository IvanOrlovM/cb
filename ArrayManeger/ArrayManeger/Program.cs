using System;
using System.ComponentModel;
using System.Linq;

namespace ArrayManeger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = UserInput();

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 100 + i;
            }

            Console.WriteLine(array.Max());

            Console.WriteLine(array.Min());

            Console.WriteLine(array.Sum());

            Console.WriteLine(array.Average());

            /*
            string s;
            if (i%2==0) 
             s = "четное";
            else 
             s = "нечетное";
            */

            for (int index = 0; index < array.Length; index++)
            {
                var value = array[index];
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);  
                }
            }

            Console.ReadKey();
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
                Console.Write("Введите число: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            return n;
        }
    }
}
