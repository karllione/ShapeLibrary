using Shaper.Classes;

namespace Shaper.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CorrectCircleArea()
        {
            var circle = new Circle(10);
            Assert.That(circle.GetArea(), Is.EqualTo(Math.PI * 25).Within(1e-9));
        }

        [Test]
        public void CorrectTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.GetArea(), Is.EqualTo(6).Within(1e-9));
        }

        [Test]
        public void TriangleIsRect()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsTriangleRectangular());
        }

        [Test]
        public void TriangleIsNotRect()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsTriangleRectangular());
        }
    }
}