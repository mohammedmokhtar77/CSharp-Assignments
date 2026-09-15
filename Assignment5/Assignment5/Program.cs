namespace Assignment5;

class Program
{
    static void Main(string[] args)
    {
        #region Part 1: Binding

        #region Q1, Q2, Q3

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

        #region Q5, Q6, Q7, Q8

        static void ProcessPerson(Person person)
        {
            person.Greet();
            person.Display();
        }
        
        Person doctor = new Doctor { Id = 1, Name = "Ali", Age = 35, 
            Specialty = "Cardiology" };

        Person engineer = new Engineer { Id = 2, Name = "Mohammed", Age = 20,
            Field = "Software Engineering", YearsOfExperience = 5 };

        ProcessPerson(doctor);
        Console.WriteLine("-------------------------------------------");
        ProcessPerson(engineer);
        
        /*
        Static Binding:
              Greet() is non-virtual, so the method is resolved at compile time
              based on the reference type (Person), therefore Person.Greet() is called.
        Dynamic Binding:
              Display() is virtual, so the method is resolved at runtime
              based on the actual object type (Doctor or Engineer), therefore
              the overridden derived Display() method is called.
              
              If I removed Virtual From Base Without Remove Override from childes:
                  CS0506: 'Doctor.Display()': cannot override inherited member 
                  'Person.Display()' because it is not marked virtual, abstract, or override
              If I removed Virtual From Base With Remove Override from childes:
                  Static Binding (Line 51)
         */
        

        #endregion  

        #endregion
        
        
        
        
        

    }
}