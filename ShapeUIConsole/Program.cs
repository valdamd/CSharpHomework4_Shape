using System;
using System.Collections.Generic;
using Shape_reliz;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Square(3),
            new Triangle(3, 4, 5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.ToString());
            Console.WriteLine(new string('-', 40)); // разделитель
        }

        Console.ReadKey();
    }
}