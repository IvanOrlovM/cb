using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t- = Rectangle = -\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                var width = GetSide("Enter width: ");
                var height = GetSide("Enter height: ");

                var rectangle = new Rectangle(width, height);
                var rectangleArea = rectangle.Area;

                var showRectangle = new ShowRectangle(rectangle);

                showRectangle.Show();

                Console.WriteLine("For the exit press any key \"q\".");

            } while (Console.ReadKey().Key != ConsoleKey.Q);
        }

        private static double GetSide(string message)
        {
            double side;
            string s;
            do
            {
                Console.Write(message);
                s = Console.ReadLine();
            } while (!double.TryParse(s, out side));

            return side;
        }
    }

    public class ShowRectangle
    {
        public ShowRectangle(Rectangle rectangle)
        {
            Figure = rectangle;
        }

        public Rectangle Figure { get; set; }

        public void Show()
        {
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < Figure.Height; i++)
            {
                Console.Write("\t\t");
                for (int j = 0; j < Figure.Width; j++)
                {
                    Console.Write("+");
                }

                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n");
        }
    }
}