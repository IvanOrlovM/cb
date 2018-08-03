namespace AddressApplication
{
    public class Address
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }
        public override string ToString()
        {
            return
                $"{nameof(Index)}: {Index}, " +
                $"{nameof(Country)}: {Country}, " +
                $"{nameof(city)}: {city}, " +
                $"{nameof(street)}: {street}, " +
                $"{nameof(house)}: {house}, " +
                $"{nameof(apartment)}: {apartment}";

        }
    }
}