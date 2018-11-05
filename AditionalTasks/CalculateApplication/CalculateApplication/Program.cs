using System;

namespace CalculateApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            string a = Console.ReadLine();
            int sum = int.Parse(a);

            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine($"{sum} * {i} = {sum * i}");
            }
            Console.ReadLine();
        }
    }
}
