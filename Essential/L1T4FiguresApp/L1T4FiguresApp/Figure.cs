namespace L1T4FiguresApp
{
    public class Figure
    {
        private string _name;
        private Point _pointA;
        private Point _pointB;
        private Point _pointC;
        private Point _pointD;

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

        public double LenghtSide(Point a, Point b)
        {
            return 8;
        }
    }
}