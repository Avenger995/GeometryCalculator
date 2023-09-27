using GeometryCalculatorLib;
using GeometryCalculatorLib.Figures;

namespace GeometryCalculatorLibTest
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleAreaIntNormalTest()
        {
            double expectedResult = 26.8;
            var triangleSides = Tuple.Create(7.0, 8.0, 9.0);
            GeometryFigure triangle = new Triangle(triangleSides);
            var result = Math.Round(triangle.GetArea(), 1);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TriangleAreaDoubleNormalTest()
        {
            double expectedResult = 56.8;
            var triangleSides = Tuple.Create(10.456, 13.543, 11.11);
            GeometryFigure triangle = new Triangle(triangleSides);
            var result = Math.Round(triangle.GetArea(), 1);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TriangleAreaNegativeValueTest()
        {
            var triangleSides = Tuple.Create(-10.456, 13.543, 11.11);
            Assert.Throws<ArgumentException>(() => new Triangle(triangleSides));
        }

        [Fact]
        public void TriangleAreaTrianglNotExistTest()
        {
            var triangleSides = Tuple.Create(1000.0, 13.543, 11.11);
            Assert.Throws<ArithmeticException>(() => new Triangle(triangleSides));
        }

        [Fact]
        public void TriangleAreaTrianglZeroTest()
        {
            var triangleSides = Tuple.Create(0.0, 13.543, 11.11);
            Assert.Throws<ArgumentException>(() => new Triangle(triangleSides));
        }
    }
}