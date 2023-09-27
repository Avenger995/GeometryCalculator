using GeometryCalculatorLib;
using GeometryCalculatorLib.Figures;

namespace GeometryCalculatorLibTest
{
    public class CircleTest
    {
        [Fact]
        public void CircleAreaIntNormalTest()
        {
            double expectedResult = 314.2;
            double circleRadius = 10;
            GeometryFigure circle = new Circle(circleRadius);
            var result = Math.Round(circle.GetArea(), 1);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CircleAreaDoubleNormalTest()
        {
            double expectedResult = 31577.6;
            double circleRadius = 100.257;
            GeometryFigure circle = new Circle(circleRadius);
            var result = Math.Round(circle.GetArea(), 1);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CircleAreaZeroTest()
        {
            double circleRadius = 0;
            Assert.Throws<ArgumentException>(() => new Circle(circleRadius));
        }

        [Fact]
        public void CircleAreaNegativeTest()
        {
            double circleRadius = -100;
            Assert.Throws<ArgumentException>(() => new Circle(circleRadius));
        }
    }
}