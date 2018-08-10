using System;

namespace L2T2ConverterApp
{
    public class Converter
    {
        private readonly double _usd;
        private readonly double _eur;
        private readonly double _rub;

        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public double Convert(double uah, CurrencyType currencyType)
        {
            if (currencyType == CurrencyType.Rub)
            {
                return uah / _rub;
            }

            if (currencyType == CurrencyType.Eur)
            {
                return uah / _eur;
            }

            if (currencyType == CurrencyType.Usd)
            {
                return uah / _usd;
            }

            throw new ArgumentException();
        }

        public double ConvertToUah(double currency, CurrencyType currencyType)
        {
            if (currencyType == CurrencyType.Usd)
            {
                return currency * _usd;
            }

            if (currencyType == CurrencyType.Eur)
            {
                return currency * _eur;
            }

            if (currencyType == CurrencyType.Rub)
            {
                return currency * _rub;
            }

            throw new ArgumentException();
        }
    }
}