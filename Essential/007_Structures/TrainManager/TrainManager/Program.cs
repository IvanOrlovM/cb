using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TrainManager
{
    public struct Train
    {
        private string Destination;
        public int Number;
        private DateTime Time;

        public Train(string destination, int number, DateTime time)
        {
            Destination = destination;
            Number = number;
            Time = time;
        }

        //i dont now what about this answer
    }
    /*
- Написать программу, выполняющую следующие действия:
	- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train
	- выполнить сортировку (записи должны быть упорядочены по номерам поездов);
	- вывод на экран информации о поезде, 
		- реализовать доступ по номеру (номер которого введен с клавиатуры)
		- выводить нотификацию, если таких поездов нет.
     создать    
     */                                                                                                                                         
    class Program
    {
        private static Item item;

        static void Main(string[] args)
        {
            var trains = new Train[8];
            for (var i = 0; i < trains.Length; i++)
            {
                trains[i] = new Train();
            }
            // пользовательский ввод
            var train = new Train();
            var number = Console.ReadLine();
            train.Number = int.Parse(number);

            Console.ReadKey();
            // инициализация Train
            train = new Train();
            // инициашизация Item
            item = new Item();

           
           
        }
    }

    internal class Item
    {
    }
}
