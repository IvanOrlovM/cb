using System;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = GetConsoleInputLine("Enter Height: ");
            int width = GetConsoleInputLine("Enter Width: ");

            //Console.Clear();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }

        public static int GetConsoleInputLine(string notification)
        {
            Console.Write(notification);
            string widthStr = Console.ReadLine();

            int result;
            while (!int.TryParse(widthStr, out result))
            {
                Console.WriteLine("You entered an incorrect value!");
                widthStr = Console.ReadLine();
            }

            return result;
        }
    }
}
