using System;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace ExpressionFileCalculator
{
    // f F
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(@"../../../", @"ExpressionGenerator/bin/Debug", "File.exp");
            var lines = File.WriteAllText(path);
            foreach (var line in lines)
            {
                Console.Write(line);
                var a = 4;
                var b = 6;
                var c = a * b;
                var result = Console.ReadLine();
                result = int.TryParse(line, out );

                if (c != 24)
                {
                    Console.WriteLine("wrong");
                }
            }


            Console.ReadLine();
        }
    }
}
