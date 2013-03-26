namespace Refactoring_101.points
{
    public class Cruft
    {
        public void DoStuff(Point point1, Point point2, Point point3, Point point4)
        {
            point1.X += 10;
            point1.Y += 10;
            point2.X += 10;
            point2.Y += 10;
            point3.X += 10;
            point3.Y += 10;
            point4.X += 10;
            point4.Y += 10;
            point1.X *= 2;
            point1.Y *= 2;
            point2.X *= 2;
            point2.Y *= 2;
            point3.X *= 2;
            point3.Y *= 2;
            point4.X *= 2;
            point4.Y *= 2;
        }
    }
}