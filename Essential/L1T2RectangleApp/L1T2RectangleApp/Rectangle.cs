namespace L1T2RectangleApp
{
    public class Rectangle
    {
        private readonly double _side1;
        private readonly double _side2;

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public double Area => AreaCalc();

        public double Perimeter => PerimeterCalc();

        public double PerimeterCalc()
        {
            return (_side1 + _side2) * 2;
        }

        public double AreaCalc()
        {
            return _side1 * _side2;
        }
    }
}