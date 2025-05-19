using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Triangle : Shape
    {
        private double sideA { get; }
        private double sideB { get; }
        private double sideC { get; }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentOutOfRangeException("The lengths of the sides must be positive.");
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentOutOfRangeException("The sum of any two sides must be greater than the third");
            }

            sideA = a;
            sideB = b;
            sideC = c;
        }
        public override double CalculateArea()
        {

            if (sideA >= sideB && sideA >= sideC)
            {
                if (IsRightTriangle(sideA, sideB, sideC))
                {
                    return RightTriangleArea(sideB, sideC);
                }
            }
            else if
                (sideB >= sideA && sideB >= sideC)
            {
                if (IsRightTriangle(sideB, sideA, sideC))
                {
                    return RightTriangleArea(sideA, sideC);
                }
            }
            else
            {
                if (IsRightTriangle(sideC, sideA, sideB))
                {
                    return RightTriangleArea(sideA, sideB);
                }
            }

            double semiperimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
            return area;


        }
        private bool IsRightTriangle(double hypotenuse, double leg1, double leg2)
        {
            double PythagoreanTheorem = hypotenuse * hypotenuse - (leg1 * leg1 + leg2 * leg2);
            return PythagoreanTheorem>0 && PythagoreanTheorem < 0.0001;
        }

        private double RightTriangleArea(double leg1, double leg2)
        {
            return leg1 * leg2 / 2;
        }
    }
}
