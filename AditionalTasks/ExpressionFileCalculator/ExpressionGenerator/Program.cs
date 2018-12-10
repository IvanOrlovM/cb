using System;
using System.IO;

namespace ExpressionGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contents = new string[10];
            var random = new Random();
            for (int i = 0; i < contents.Length; i++)
            {
                var a = random.Next(1, 10);
                var b = random.Next(1, 10);
                var indexOper = random.Next(1, 4);
                var o = new[] {"+", "-", "*", "/"}[indexOper];
                var exp = $"{a}{o}{b}=";
                contents[i] = exp;
            }
            
            File.AppendAllLines("File.exp", contents);
        Console.ReadLine();
        }
    }
}