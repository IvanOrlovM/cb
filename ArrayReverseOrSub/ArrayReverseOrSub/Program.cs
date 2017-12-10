using System;

namespace ArrayReverseOrSub
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t-= ArrayReverseOrSub =-\n");

            MyReverse();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nThe end!\nFor the exit press Q\nfor continue press any key.");
            bool b = Console.ReadKey().Key != ConsoleKey.Q;
        }

        private static void MyReverse()
        {
            int[] array = new int[234];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}