namespace L1T4FiguresApp
{
    public class Point
    {
        public Point(string name, int y, int x)
        {
            Name = name;
            Y = y;
            X = x;
        }

        public string Name { get; }

        public int X { get; }

        public int Y { get; }
    }
}