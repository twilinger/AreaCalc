using AreaCalc;

namespace AreaUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Circle a = new Circle(2);
            Assert.AreEqual(12.56, a.CalculateArea());
        }
        [Test]
        public void Test2()
        {
            Triangle a = new Triangle(6,8,10);
            Assert.AreEqual(24, a.CalculateArea());
        }
        [Test]
        public void Test3()
        {
            Triangle a = new Triangle(6, 8, 10);
            Assert.IsTrue(a.CheckRectangular());
        }
    }
}