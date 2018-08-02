using System;

namespace AddressApplication
{
    class Program
    {
        private static string Kiev;
        private static string Mury;

        static void Main(string[] args)
        {
            new Address();
            {
                Address.index = 08130;
                Address.country = Kiev;
                Address.city = Kiev;
                Address.street = Mury;
                Address.house = 11;
                Address.apartment = 6;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
