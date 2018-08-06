namespace L1T2RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(10, 20);
            double area = rectangle.Area();
            double perimeter = rectangle.Perimeter();
        }
    }
}
