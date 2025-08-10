namespace ShapeAlgotitm;
public sealed class Triangle : Shape
{
    private double _sideA;
    private double _sideB;
    private double _sideC;
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (HasPositiveSides(sideA, sideB, sideC) && TringleExists(sideA, sideB, sideC)) {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }else {
            throw new ArgumentException("The triangle doesn't have positive sides or it doesn't exist");
        }
    }
    public override double CalculateArea()
    {
        // Implementing the area calculation using Heron's formula
        double s = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }
    public override double CalculatePerimeter() =>_sideA + _sideB + _sideC;
    private static bool TringleExists(double sideA, double sideB, double sideC) => 
        sideA + sideB > sideC && 
        sideB + sideC > sideA && 
        sideC + sideA > sideB;
    private bool HasPositiveSides(double sideA, double sideB, double sideC) => sideA > 0 && sideB > 0 && sideC > 0;
    public override string ToString()
    {
        return $"Shape: Triangle\n" +
               $"Sides: {_sideA}, {_sideB}, {_sideC}\n" +
               $"Perimeter: {CalculatePerimeter():F2}\n" +
               $"Area: {CalculateArea():F2}";
    }
}