using System;
using Xunit;
using AreaOfTheFigure;

namespace AreaTests
{
    public class Tests
    {
        [Fact]
        public void JustCircle()
        {
            Circle oneCircle = new Circle(5);
            Assert.Equal(78.5, oneCircle.CalculateArea());
        }

        [Fact]
        public void JustTriangle()
        {
            Triangle oneTriangle = new Triangle(1, 2, 2);
            Assert.False(oneTriangle.CheckRightTriangle());
            Assert.True(Math.Abs(0.968 - oneTriangle.CalculateArea())<0.001);
        }

        [Fact]
        public void RightTriangle()
        {
            Triangle otherTriangle = new Triangle(5, 12, 13);
            Assert.True(otherTriangle.CheckRightTriangle());
            Assert.True(Math.Abs(30 - otherTriangle.CalculateArea()) < 0.00001);
        }

        [Fact]
        public void FromFigureToCircle()
        {
            Figure oneFigure = new Circle(10);
            Assert.Equal(314, oneFigure.CalculateArea());
        }

        [Fact]
        public void FromFigureToTriangle()
        {
            Figure oneFigure = new Triangle(1, 2, 2);
            Assert.True(Math.Abs(0.968 - oneFigure.CalculateArea()) < 0.001);
        }
    }
}
