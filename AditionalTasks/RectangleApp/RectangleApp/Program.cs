using System;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            string str = Console.ReadLine();
            int height = int.Parse(str);
            for (int i = 0, k = -1; i < height; i++, k += 2)
            {
                for (int j = 0; j < height - 1 - i; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                if (k > 0)
                {
                    for (int j = 0; j < k; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 0, k = height; i < height - 1; i++, k -= 2) 
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int j = 0; j < k; j++)
                {
                    Console.Write(" ");
                }

                if (k > 0) 
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
