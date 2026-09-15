namespace Assignment5;

public class Shape
{
    public double Width { get; set; }
    
    public double Height { get; set; }

    Shape(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public double Area()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return $"(Width = {Width} , Height = {Height})";
    }
}