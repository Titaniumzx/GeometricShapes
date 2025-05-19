using GeometricShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeometricShapes
{
    [TestFixture]
    internal class TriangleTests
    {     
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(1, 2, 4)] 
        public void ConstructorInvalidSidesThrowsException(double a, double b, double c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
        }
       
        [TestCase(3, 4, 5, 6)]
        [TestCase(5, 5, 6, 12)]
        [TestCase(7, 8, 9, 26.8328)]
        public void CalculateAreaValidTriangleReturnsCorrectArea(double a, double b, double c, double expected)
        {
            IShape triangle = new Triangle(a, b, c);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(expected).Within(0.0001));
        }
       
        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(8, 15, 17)]
        public void CalculateAreaRightTriangleUsesRightFormula(double a, double b, double c)
        {
            IShape triangle = new Triangle(a, b, c);
            double expected = (a * b) / 2;
            Assert.That(triangle.CalculateArea(), Is.EqualTo(expected).Within(0.0001));
        }
    
        [Test]
        public void CalculateAreaEquilateralTriangleReturnsCorrectArea()
        {
            IShape triangle = new Triangle(2, 2, 2);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(1.73205).Within(0.0001));
        }
    }
}
