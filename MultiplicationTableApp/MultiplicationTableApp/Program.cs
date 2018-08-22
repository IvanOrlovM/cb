using System;

namespace MultiplicationTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine($"X{i}");
                var str = "";
                for (int j = 2; j < 10; j++)
                {
                    str = str + $"{i}*{j}={j * i}\n";
                }

                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
