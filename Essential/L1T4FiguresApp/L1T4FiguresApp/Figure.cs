namespace L1T4FiguresApp
{
    public class Figure
    {
        private string _name;
        private Point _pointA;
        private Point _pointB;
        private Point _pointC;
        private Point _pointD;
        private Point _pointE;

        public Figure(string name, Point pointA, Point pointB, Point pointC)
        {
            _name = name;
            _pointA = pointA;
            _pointB = pointB;
            _pointC = pointC;
        }

        public Figure(string name, Point pointA, Point pointB, Point pointC, Point pointD) : this(name, pointA, pointB, pointC)
        {
            _pointD = pointD;
        }

        public Figure(string name, Point pointA, Point pointB, Point pointC, Point pointD, Point pointE) : this(name, pointA, pointB, pointC, pointD)
        {
            _pointE = pointE;
        }

        public double LenghtSide(Point a, Point b)
        {
            return 8;// TODO: Here will be implementation
        }

        public double PerimeterCalculator()
        {
            return 2;// TODO: Here will be implementation
        }
    }
}