using System;

namespace ArithmeticForLambda
{
    public class Calc
    {
        public double Sub(double a, double b) => a - b;

        public double Add(double a, double b) => a + b;

        public double Mul(double a, double b) => a * b;

        public Func<double, double, double> Div = (a, b) =>
        {
            if (b == 0)
            {
                throw new ArgumentException(nameof(b));
            }

            return a / b;
        };
    }
}