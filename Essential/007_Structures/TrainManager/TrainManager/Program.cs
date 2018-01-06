using System;
using System.Globalization;

namespace TrainManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                string param = args[i];
                string[] trainParams = param.Split(',');
                trains[i] = UserInputTrain(trainParams[0], trainParams[1], trainParams[2]);
            }

            Console.ReadKey();
        }

        private static Train UserInputTrain(string trainNumber = "", string destination = "", string beginTime = "")
        {
            if (string.IsNullOrEmpty(destination))
            {
                Console.Write("Введите пункт назначения: ");
                destination = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(trainNumber))
            {
                Console.Write("Введите номер поезда: ");
                trainNumber = Console.ReadLine();
            }

            var number = int.Parse(trainNumber);

            if (string.IsNullOrEmpty(beginTime))
            {
                Console.Write("Введите время отправления (В формате HH:mm): ");
                beginTime = Console.ReadLine();
            }

            var time = DateTime.ParseExact(beginTime, "HH:mm", CultureInfo.CurrentCulture);

            var train = new Train(destination, number, time);
            return train;
        }
    }
}