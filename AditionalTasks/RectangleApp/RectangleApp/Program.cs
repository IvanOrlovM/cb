using System;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter height: ");
                string str = Console.ReadLine();
                int height = int.Parse(str);
                var k = -1;
                for (int i = 0; i < height; i++, k += 2)
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

                k -= 4;

                for (int i = 0; i < height - 1; i++, k -= 2)
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
            } while (Console.ReadKey().Key == ConsoleKey.Enter);

            Console.ReadLine();
        }
    }
}
