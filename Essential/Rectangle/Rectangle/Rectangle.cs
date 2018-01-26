namespace Rectangle
{
    public class Rectangle
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
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