using System;

namespace ArraysApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiDimensional();
            SingleDimensional();

            Console.ReadKey();
        }

        private static void MultiDimensional()
        {
            int[][] array = new int[10][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[10];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = int.Parse($"{i}{j}");
                }
            }
            PrintArray(array);
        }

        public static void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void SingleDimensional()
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
                Console.Write(array[i] + " ");
            }
        }
    }
}
