using System;

namespace AreaOfTheFigure
{
    public class Triangle : Figure
    {
        private double firstBisector, secondBisector;
        private double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double CalculateArea()
        {
            double area, halfPerimater;
            if (CheckRightTriangle()) {
                area = 0.5 * firstBisector * secondBisector;
            } else {
                halfPerimater = (a + b + c) / 2.0;
                area = Math.Sqrt(halfPerimater * (halfPerimater - a) * (halfPerimater - b) * (halfPerimater - c));
            }
            return area;
        }

        public bool CheckRightTriangle()
        {
            if (Math.Abs((a * a) + (b * b) - (c * c)) < 0.000001) {
                firstBisector = a;
                secondBisector = b;
                return true;
            }
            if (Math.Abs((a * a) + (c * c) - (b * b)) < 0.000001) {
                firstBisector = a;
                secondBisector = c;
                return true;
            }
            if (Math.Abs((b * b) + (c * c) - (a * a)) < 0.000001) {
                firstBisector = b;
                secondBisector = c;
                return true;
            }
            return false;
        }
    }
}
