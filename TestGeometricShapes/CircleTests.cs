using GeometricShapes;

namespace TestGeometricShapes
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(67, 14102.60942)]
        [TestCase(1, 3.1416)]
        [TestCase(3.9, 47.78362)]
        [TestCase(0, 0)]
        public void CalculateAreaValidRadiusReturnsCorrectArea(double radius, double expected)
        {
            IShape circle = new Circle(radius);
            Assert.That(circle.CalculateArea(), Is.EqualTo(expected).Within(0.0001));
        }

        [TestCase(-1)]
        [TestCase(-0.03)]
        public void ConstructorInvalidRadiusThrowsException(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }
    }
}