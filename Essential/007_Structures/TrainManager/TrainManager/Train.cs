using System;

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
    }
}