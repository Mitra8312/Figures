using NUnit.Framework;
using Figures.Figures;

namespace FigureTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            Assert.That(circle.GetArea() == Math.PI * 25, Is.True);
        }

        [Test]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6; 
            Assert.That((triangle.GetArea()) == expectedArea, Is.True);
        }

        [Test]
        public void TriangleRightAngleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRightTriangle());
        }

        [Test]
        public void InvalidTriangleTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-100)]
        public void InvalidCircleRadiusTest(int value)
        {
            Assert.Throws<ArgumentException>(() => new Circle(value));
        }
    }
}