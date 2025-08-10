
using ShapeAlgoritm;
using Xunit;
using ShapeAlgotitm;
using Assert = Xunit.Assert;
namespace CSharpHomework4_Shape;
public class Tests
{
    [Fact]
    public void Circle_CorrectAreaAndPerimeter()
    {
        var circle = new Circle(2);
        Assert.Equal(Math.PI * 4, circle.CalculateArea(), 3);
        Assert.Equal(2 * Math.PI * 2, circle.CalculatePerimeter(), 3);
    }

    [Fact]
    public void Rectangle_CorrectAreaAndPerimeter()
    {
        var rect = new Rectangle(4, 5);
        Assert.Equal(20, rect.CalculateArea());
        Assert.Equal(18, rect.CalculatePerimeter());
    }

    [Fact]
    public void Square_CorrectAreaAndPerimeter()
    {
        var square = new Square(3);
        Assert.Equal(9, square.CalculateArea());
        Assert.Equal(12, square.CalculatePerimeter());
    }

    [Fact]
    public void Triangle_CorrectAreaAndPerimeter()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.CalculateArea(), 2);
        Assert.Equal(12, triangle.CalculatePerimeter());
    }

    [Xunit.Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void Circle_InvalidRadius_Throws(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Xunit.Theory]
    [InlineData(0, 5)]
    [InlineData(5, -2)]
    public void Rectangle_InvalidDimensions_Throw(double width, double height)
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
    }

    [Xunit.Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Square_InvalidSide_Throws(double side)
    {
        Assert.Throws<ArgumentException>(() => new Square(side));
    }

    [Xunit.Theory]
    [InlineData(1, 2, 10)] // a + b <= c
    [InlineData(5, 1, 1)]  // a >= b + c
    public void Triangle_InvalidSides_Throws(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Fact]
    public void Polymorphism_WorksCorrectly()
    {
        Shape[] shapes =
        {
            new Circle(1),
            new Rectangle(2, 3),
            new Square(4),
            new Triangle(3, 4, 5)
        };

        foreach (var shape in shapes)
        {
            Assert.True(shape.CalculateArea() > 0);
            Assert.True(shape.CalculatePerimeter() > 0);
            Assert.Contains("Shape:", shape.ToString(), StringComparison.OrdinalIgnoreCase);
        }
    }
}