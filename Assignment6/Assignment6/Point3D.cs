namespace Assignment6;

public class Point3D
{
    public int X { get; set; }
    
    public int Y { get; set; }
    
    public int Z { get; set; }

    public Point3D():this(0,0,0)
    {
        
    }

    public Point3D(int x):this(x, 0, 0)
    {
        
    }
    
    public Point3D(int x, int y) : this(x, y, 0)
    {
    }
    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return $"Point Coordinates: ({X} , {Y} , {Z})";
    }
}