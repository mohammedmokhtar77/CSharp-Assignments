namespace Assignment6;

public class Point3D : IComparable<Point3D> , ICloneable
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

    public int CompareTo(Point3D? other)
    {
        int result = X.CompareTo(other?.X);
        if (result == 0)
        {
            result = Y.CompareTo(other?.Y);
        }
        return result;
    }

    public override string ToString()
    {
        return $"Point Coordinates: ({X} , {Y} , {Z})";
    }

    public object Clone()
    {
        return new Point3D(X, Y, Z);
    }
}