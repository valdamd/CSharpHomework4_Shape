using ShapeAlgotitm;
namespace ShapeAlgoritm;
public sealed class Square : Shape
{
    private double _side;
    public Square(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Side length must be positive.");
        _side = side;
    }
    public override double CalculateArea() => _side * _side;
    public override double CalculatePerimeter() => 4 * _side;
    public override string ToString()
    {
        return $"Shape: Square\n" +
               $"Side: {_side}\n" +
               $"Perimeter: {CalculatePerimeter():F2}\n" +
               $"Area: {CalculateArea():F2}";
    }
}