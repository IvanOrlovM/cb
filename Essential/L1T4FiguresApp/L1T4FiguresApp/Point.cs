namespace L1T4FiguresApp
{
    public class Point
    {
        private string _name;

        public string Name
        {
            get { return _name; }
        }

        private int _y;
        public int x
        {
            get { return _x; }
        }
        private int _x;

        public int y
        {
            get { return _y; }
        }

        public Point(string name, int y, int x)
        {
            _name = name;
            _y = y;
            _x = x;
        }
    }
}