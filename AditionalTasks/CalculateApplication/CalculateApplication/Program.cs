using System;

namespace CalculateApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            string a = Console.ReadLine();
            int num1 = int.Parse(a);
            Console.Write("Enter b: ");
            string b = Console.ReadLine();
            int num2 = int.Parse(b);
            Console.Clear();
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.ReadLine();
        }
    }
}
