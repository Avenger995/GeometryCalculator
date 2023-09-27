
namespace GeometryCalculatorLib.Figures
{
    public class Circle: GeometryFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным или равен нулю! :(");
            }

            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }
    }
}
