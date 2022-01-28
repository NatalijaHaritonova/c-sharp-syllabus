namespace Exercise9
{
    internal class Point
    {
        public int _x { get; set; }
        public int _y { get; set; }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public static void SwapPoints(Point one, Point two)
        {
            int oneX = one._x;
            int oneY = one._y;
            one._x = two._x;
            one._y = two._y;
            two._x = oneX;
            two._y = oneY;
        }
    }
}
