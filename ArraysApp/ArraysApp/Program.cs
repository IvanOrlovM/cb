using System;

namespace ArraysApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -= 10x10 =-");

            int[][] array = MultiDimensional();
            PrintArray(array);

            Console.WriteLine("\n -= 1x10 =-");
            SingleDimensional();

            Console.ReadKey();
        }

        private static int[][] MultiDimensional()
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

            return array;
        }

        public static void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] >= 0 && array[i][j] <= 9)
                    {
                        Console.Write("0");
                    }

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
