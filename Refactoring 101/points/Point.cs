namespace Refactoring_101.points
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int moveBy)
        {
            X += moveBy;
            Y += moveBy;
        }

        public void Scale(int scaleBy)
        {
            X *= scaleBy;
            Y *= scaleBy;
        }
    }
}