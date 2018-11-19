using System;

namespace CalculateApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************");
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    int a = j * i;
                    Console.WriteLine($"* {i} * {j} = {a} {(a < 10 ? " " : "")} *");
                }
                Console.WriteLine("***************");
            }
            Console.ReadLine();
        }
    }
}
