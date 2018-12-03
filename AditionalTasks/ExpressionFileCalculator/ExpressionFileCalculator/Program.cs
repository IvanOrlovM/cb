using System;
using System.IO;
using System.Net;

namespace ExpressionFileCalculator
{
    // f F
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("file.exp");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
