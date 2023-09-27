
namespace GeometryCalculatorLib.Figures
{
    public class Triangle: GeometryFigure
    {
        private readonly Tuple<double, double, double> _sides;

        public Triangle(Tuple<double, double, double> sides) 
        {
            if (IsSidesNegativeOrZero(sides))
            {
                throw new ArgumentException("Стороны треугольника не могу быть отрицательными или равен нулю! :(");
            }
            if (IsTriangleNotExist(sides))
            {
                throw new ArithmeticException("Такого треугольника не существует");
            }
            _sides = sides;
        }

        private static bool IsSidesNegativeOrZero(Tuple<double, double, double> sides)
        {
            return sides.Item1 <= 0 || sides.Item2 <= 0 || sides.Item3 <= 0;
        }

        private static bool IsTriangleNotExist(Tuple<double, double, double> sides)
        {
            return sides.Item1 > (sides.Item2 + sides.Item3) || sides.Item2 > (sides.Item1 + sides.Item3) || sides.Item3 > (sides.Item1 + sides.Item2);
        }

        public override double GetArea()
        {
            var semiPerimeter = GetSemiPerimeter(_sides);
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sides.Item1) * (semiPerimeter - _sides.Item2) * (semiPerimeter - _sides.Item3));
        }

        private static double GetSemiPerimeter(Tuple<double, double, double> sides)
        {
            return (sides.Item1 + sides.Item2 + sides.Item3) / 2;
        }

        public bool IsTriangleRight()
        {
            double hypotenuse = GetHypotenuse();
            double sumOfSquares = Math.Pow(_sides.Item1, 2) + Math.Pow(_sides.Item2, 2) + Math.Pow(_sides.Item3, 2) - Math.Pow(hypotenuse, 2);
            return sumOfSquares == Math.Pow(hypotenuse, 2);
        }

        private double GetHypotenuse()
        {
            return Math.Max(_sides.Item1, Math.Max(_sides.Item2, _sides.Item3));
        }
    }
}
