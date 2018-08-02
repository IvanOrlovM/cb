using System;

namespace AddressApplication
{
    class Program
    {
        private static string Kiev = Kiev;
        private static string Mury = Mury;

        static void Main(string[] args)
        {
            new Address()
            {
                index = 08130,
                country = Kiev,
                city = Kiev,
                street = Mury,
                house = 11,
                apartment = 6,
            };
            Console.ReadLine();

        }
    }
}
