namespace Shape_reliz;

public abstract class Shape
{
   public string Name { get; set; }
   

   public abstract double CalculateArea();
   public abstract double CalculatePerimeter();

   public override string ToString()
   {
       return $"Shape: {GetType().Name}\n" +
              $"Area: {CalculateArea():F2}\n" +
              $"Perimeter: {CalculatePerimeter():F2}";
   }
}