using GeometryCalculatorLib;
using GeometryCalculatorLib.Figures;

class Program
{
    static void Main()
    {
        double circleRadius = 12.5;
        Tuple<double, double, double> triangleSides = Tuple.Create((double)3, (double)4, (double)5);

        GeometryFigure circle = new Circle(circleRadius);
        Triangle triangle = new(triangleSides);

        var radiusAreaResult = circle.GetArea();
        var triangleAreaResult = triangle.GetArea();
        var isTriangleRightResult = triangle.IsTriangleRight() ? "Прямоугольный" : "Непрямоугольный";

        Console.WriteLine($"Площадь круга с радиусом {circleRadius} = {radiusAreaResult}");
        Console.WriteLine($"Площадь треугольника со сторонами {triangleSides.Item1}, {triangleSides.Item2}, {triangleSides.Item3} = {triangleAreaResult}");
        Console.WriteLine($"Треугольник со сторонами {triangleSides.Item1}, {triangleSides.Item2}, {triangleSides.Item3} {isTriangleRightResult}");
    }
}
