namespace Assignment6;

class Program
{
    static void Main(string[] args)
    {
        #region Project One

        #region Q1 ,Q2

        // Point3D point3D = new Point3D (10,10,10);
        // Console.WriteLine(point3D); // Point Coordinates: (10 , 10 , 10)

        #endregion

        #region Q3

        // 1st Way
        // Console.Write("Enter P1 coordinates (X Y Z): ");
        // int[] p1Values = Array.ConvertAll(
        //     Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries),
        //     int.Parse
        // );
        //
        // Point3D p1 = new Point3D(p1Values[0], p1Values[1], p1Values[2]);
        //
        // Console.Write("Enter P2 coordinates (X Y Z): ");
        // int[] p2Values = Array.ConvertAll(
        //     Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries),
        //     int.Parse
        // );
        //
        // Point3D p2 = new Point3D(p2Values[0], p2Values[1], p2Values[2]);
        //
        // Console.WriteLine($"P1 = {p1}");
        // Console.WriteLine($"P2 = {p2}");
        
        // 2nd Way 
        // Console.WriteLine("Enter coordinates for P1 (X Y Z):");
        //
        // int x1, y1, z1;
        //
        // while (!int.TryParse(Console.ReadLine(), out x1))
        // {
        //     Console.Write("Invalid X. Enter again: ");
        // }
        //
        // while (!int.TryParse(Console.ReadLine(), out y1))
        // {
        //     Console.Write("Invalid Y. Enter again: ");
        // }
        //
        // while (!int.TryParse(Console.ReadLine(), out z1))
        // {
        //     Console.Write("Invalid Z. Enter again: ");
        // }
        //
        // Point3D P1 = new Point3D(x1, y1, z1);
        //
        //
        // Console.WriteLine("Enter coordinates for P2 (X Y Z):");
        //
        // int x2, y2, z2;
        //
        // while (!int.TryParse(Console.ReadLine(), out x2))
        // {
        //     Console.Write("Invalid X. Enter again: ");
        // }
        //
        // while (!int.TryParse(Console.ReadLine(), out y2))
        // {
        //     Console.Write("Invalid Y. Enter again: ");
        // }
        //
        // while (!int.TryParse(Console.ReadLine(), out z2))
        // {
        //     Console.Write("Invalid Z. Enter again: ");
        // }
        //
        // Point3D P2 = new Point3D(x2, y2, z2);
        //
        // Console.WriteLine($"P1 = {P1}");
        // Console.WriteLine($"P2 = {P2}");

        #endregion

        #region Q4

        // Point3D p1 = new Point3D(10, 20, 30);
        // Point3D p2 = new Point3D(10, 20, 30); // Not Equals As == compare references
        // if(p1 == p2)
        //     Console.WriteLine("Equals");
        // else
        //     Console.WriteLine("Not equals");

        #endregion

        #region Q5

        // Point3D[] points =
        // {
        //     new Point3D(5, 10, 20),
        //     new Point3D(2, 30, 40),
        //     new Point3D(5, 5, 15),
        //     new Point3D(1, 20, 30),
        //     new Point3D(2, 10, 25)
        // };
        // Array.Sort(points);
        // foreach (Point3D point in points)
        // {
        //     Console.WriteLine(point);
        // }

#endregion

        #endregion

        #region Second Project

        // Console.WriteLine(Math.Add(10, 5));
        // Console.WriteLine(Math.Subtract(10, 5));
        // Console.WriteLine(Math.Multiply(10, 5));
        // Console.WriteLine(Math.Divide(10, 5));

        #endregion

        #region Q1, Q2, Q3

        // Duration d1 = new Duration(1, 10, 15);
        // Console.WriteLine(d1.ToString()); // Hours: 1, Minutes :10, Seconds :15
        //
        // Duration d2 = new Duration(3600);
        // Console.WriteLine(d2.ToString()); // Hours: 1, Minutes :0, Seconds :0
        //
        // Duration d3 = new Duration(7800);
        // Console.WriteLine(d3.ToString()); // Hours: 2, Minutes :10, Seconds :0
        //
        // Duration d4 = new Duration(666);
        // Console.WriteLine(d4.ToString()); // Minutes :11, Seconds :6

        #endregion
        
        
        
    }
}