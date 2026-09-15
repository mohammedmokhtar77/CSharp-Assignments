namespace Assignment5;

public class Cube : Shape
{
    public double Depth { get; set; }

    Cube(double width, double height, double depth):base(width, height)
    {
        Depth = depth;
    }

    public new double Area()
    {
        return base.Area() * Depth;
    }
    
    public void Print()
    {
        Console.WriteLine($"(Width = {Width} , Height = {Height} , Depth = {Depth})");
    }
}