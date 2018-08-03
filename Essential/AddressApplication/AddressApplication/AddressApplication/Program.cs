using System;

namespace AddressApplication
{
    public class Program
    {
        public static void Main()
        {
            var address = new Address
            {
                Country = "111",
                Index = 22,
                apartment = 33,
                city = "444",
                house = 55,
                street = "777"
            };

            Console.WriteLine(address);
        }
    }
}
