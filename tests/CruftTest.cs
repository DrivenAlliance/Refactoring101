using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring_101.points;

namespace tests
{
    [TestClass]
    public class CruftTest
    {
        [TestMethod]
        public void TestDoStuff()
        {
            var cruft = new Cruft();

            var point1 = new Point(0, 0);
            var point2 = new Point(2, 0);
            var point3 = new Point(2, 2);
            var point4 = new Point(0, 2);

            cruft.MoveAndScale(10, 2, point1, point2, point3, point4);

            Assert.AreEqual(20, point1.X);
            Assert.AreEqual(20, point1.Y);

            Assert.AreEqual(24, point2.X);
            Assert.AreEqual(20, point2.Y);

            Assert.AreEqual(24, point3.X);
            Assert.AreEqual(24, point3.Y);

            Assert.AreEqual(20, point4.X);
            Assert.AreEqual(24, point4.Y);
        }
    }
}