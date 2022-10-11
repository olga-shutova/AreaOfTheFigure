using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfTheFigure
{
    public class Circle : Figure
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            double area = radius * radius * 3.14;
            return area;
        }
    }
}
