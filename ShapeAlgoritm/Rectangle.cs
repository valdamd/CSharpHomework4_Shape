using ShapeAlgotitm;

namespace ShapeAlgoritm;
public sealed class Rectangle : Shape
{
    private double _width;
    private double _height;
    public Rectangle(double width, double height) {
        if (Validation(width, height)) 
            throw new ArgumentException("width and height must be greater than zero");
        _width = width;
        _height = height;
        
    }

    public override double CalculateArea() => _width * _height;
    
    public override double CalculatePerimeter() => 2 * (_width + _height);
    
    private bool Validation(double width, double height) => width <= 0 || height <= 0;

    public override string ToString()
    {
        return $"Shape: Rectangle\n" +
               $"Width: {_width}, Height: {_height}\n" +
               $"Perimeter: {CalculatePerimeter():F2}\n" +
               $"Area: {CalculateArea():F2}";
    }
}