namespace ShapeAlgotitm;
public sealed class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        if (radius > 0)
        {
            _radius = radius;
        }
        else
        {
            throw new ArgumentException("radius must be positive");
        }
    }

    public override double CalculateArea()=> Math.PI * _radius * _radius;
    

    public override double CalculatePerimeter() => 2 * Math.PI * _radius;

    public override string ToString()
    {
        return $"Shape: Circle\n" +
               $"Radius: {_radius}\n" +
               $"Perimeter: {CalculatePerimeter():F2}\n" +
               $"Area: {CalculateArea():F2}";
    }
}