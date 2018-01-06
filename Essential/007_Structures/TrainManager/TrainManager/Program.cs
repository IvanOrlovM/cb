using System;
using System.Globalization;

namespace TrainManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train0 = UserInputTrain();

            Console.ReadKey();
        }

        private static Train UserInputTrain()
        {
            Console.Write("Введите пункт назначения: ");
            string destination = Console.ReadLine();

            Console.Write("Введите номер поезда: ");
            string trainNumber = Console.ReadLine();
            int number = int.Parse(trainNumber);

            Console.Write("Введите время отправления (В формате HH:mm): ");
            string beginTime = Console.ReadLine();
            DateTime time = DateTime.ParseExact(beginTime, "HH:mm", CultureInfo.CurrentCulture);
            var train = new Train(destination, number, time);
            return train;
        }
    }
}