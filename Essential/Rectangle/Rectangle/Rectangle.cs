namespace Rectangle
{
    public class Rectangle
    {
        private double _area;

        private double _perimeter;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            _area = AreaCalculator();
            _perimeter = PerimeterCalculator();
        }

        public double Area
        {
            get
            {
                return _area;
            }
        }

        public double Perimeter
        {
            get { return _perimeter; }
        }

        public double Height { get; }

        public double Width { get; }

        public double AreaCalculator()
        {
            double area = Height * Width;
            return area;
        }

        public double PerimeterCalculator()
        {
            double perimeter = (Width + Height) * 2;
            return perimeter;
        }
    }
}