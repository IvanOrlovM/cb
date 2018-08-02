using System;
using System.Dynamic;

namespace AddressApplication
{
    public class Address
    {
        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(index)}: {index}, " +
                $"{nameof(country)}: {country}, " +
                $"{nameof(city)}: {city}, " +
                $"{nameof(street)}: {street}, " +
                $"{nameof(house)}: {house}, " +
                $"{nameof(apartment)}: {apartment}";
        }
    }
}