using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Circle : Shape
    {
        private double radius { get; }
       
            public Circle(double radius)
        {
            if (radius < 0 )
            {
                throw new ArgumentOutOfRangeException("The radius must be positive.");
            }

            this.radius = radius;
        }
        public override double CalculateArea()
        {
            double area = Math.PI * radius* radius;
            return area;
        }
    }
}
