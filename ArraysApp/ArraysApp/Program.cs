using System;

namespace ArraysApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            ShowArray(array);
        }

        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }

            Console.ReadKey();
        }
    }
}
