namespace Assignment5;

class Program
{
    static void Main(string[] args)
    {
        #region Q3

        Shape shape = new Shape(2, 3);
        Console.WriteLine(shape.Area()); // 6

        Cube cube = new Cube(2, 3, 4);
        Console.WriteLine(cube.Area()); // 24 

        // Static Binding (Early Binding) At Compilation Time
        Shape shapeRef = new Cube(2, 3, 4);
        Console.WriteLine(shapeRef.Area()); // 6 As Implemented Area of Ref (Shape) , new hidden.

        #endregion

        #region Q4

        object obj = new Cube(1, 2, 3);
        Console.WriteLine(obj.ToString()); 
        /*
         (Width = 1 , Height = 2) of shape as i override ToString() at class shape 
         and didn't override it at Cube 
         if I did , print = (Width = 1 , Height = 2 , Depth = 3)
         (Dynamic Binding or Late Binding) ====> CLR At Runtime.
         */

        #endregion
        
        
        
        

    }
}