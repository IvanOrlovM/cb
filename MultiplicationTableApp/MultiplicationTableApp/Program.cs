using System;

namespace MultiplicationTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2, a = 2; i < 10; i++)
            {
                Console.WriteLine($"{a}*{i}={a*i}");
            }

            Console.ReadLine();
        }
    }
}
