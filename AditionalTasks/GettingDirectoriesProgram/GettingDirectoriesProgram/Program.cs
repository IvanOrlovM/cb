using System;
using System.IO;

namespace GettingDirectoriesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            string path = "C:\\";

            if (Directory.Exists(path))
            {
                Console.WriteLine("Subdirectory: ");
                string[] dirs = Directory.GetDirectories(path);

                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Files:");

                string[] files = Directory.GetFiles(path);

                foreach (string s in files)

                {

                    Console.WriteLine(s);

                }
            }

            Console.ReadLine();
        }
    }
}
