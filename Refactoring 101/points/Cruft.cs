namespace Refactoring_101.points
{
    public class Cruft
    {
        public void MoveAndScale(int moveBy,
                                 int scaleBy,
                                 Point point1,
                                 Point point2,
                                 Point point3,
                                 Point point4)
        {
            Move(moveBy, point1, point2, point3, point4);
            Scale(scaleBy, point1, point2, point3, point4);
        }

        private static void Scale(int scaleBy,
                                  Point point1,
                                  Point point2,
                                  Point point3,
                                  Point point4)
        {
            point1.Scale(scaleBy);
            point2.Scale(scaleBy);
            point3.Scale(scaleBy);
            point4.Scale(scaleBy);
        }

        private void Move(int moveBy,
                          Point point1,
                          Point point2,
                          Point point3,
                          Point point4)
        {
            point1.Move(moveBy);
            point2.Move(moveBy);
            point3.Move(moveBy);
            point4.Move(moveBy);
        }
    }
}