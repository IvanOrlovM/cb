using System;

namespace CalculateApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0x2500; i <= 0x2570; i += 0x10)
            //{
            //    for (int c = 0; c <= 0xF; ++c)
            //    {
            //        Console.Write($"{i + c}{(char)(i + c)} ");
            //    }

            //    Console.WriteLine("/n");
            //}

            Console.WriteLine($"{(char)9484}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9472}" +
                              $"{(char)9488}");
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 9; j++)
                {
                    int a = j * i;
                    Console.WriteLine($"{(char)9474} {i} * {j} = {a} {(a < 10 ? " " : "")} {(char)9474}");
                }

                Console.WriteLine($"{(char)9500}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9472}" +
                                  $"{(char)9508}");
            }

            Console.WriteLine($"{(char) 9492}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9472}" +
                              $"{(char) 9496}");

            Console.ReadLine();
        }
    }
}
