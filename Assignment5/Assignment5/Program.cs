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

        #region Part 2: Interfaces 

        #region Q9

        /* Q9. (Pre-interface problem) Create a class Car with methods MoveForward() and 
        MoveBackward() that just print messages. Now imagine you also need MoveUp()/MoveDown(). 
            What is the problem with forcing every vehicle class to implement all four methods? (This is 
            what interfaces solve.) 
            
        Problem:
         Forcing every vehicle to implement all four methods (MoveForward, MoveBackward,
         MoveUp, and MoveDown) leads to unnecessary and meaningless methods.
         For example, a Car can move forward and backward but cannot move up or down.
         Interfaces solve this problem by allowing each class to implement only the
         behaviors that are relevant to it. */

        #endregion

        #region Q10, Q11, Q12

        // Create each class with its concrete type
        Console.WriteLine("======== Car ========");
        Car car = new Car();
        car.MoveForward(); // Car is moving forward on the ground.
        car.MoveBackward(); // Car is moving backward on the ground.

        Console.WriteLine("======== Ship ========");
        Ship ship = new Ship();
        ship.MoveForward(); // Ship is moving forward on the ground.
        ship.MoveBackward(); // Ship is moving backward on the ground.

        Console.WriteLine("======== Airplane ========");
        Airplane airplane = new Airplane();
        airplane.MoveForward(); // Airplane is moving forward in the air.
        airplane.MoveBackward(); // Airplane is moving backward in the air.
        airplane.MoveUp(); // Airplane is moving up in the air.
        airplane.MoveDown(); // Airplane is moving down in the air.


        // Interface references
        Console.WriteLine("======== InterfaceRef ========");
        IMoveable carRef = new Car();
        carRef.MoveForward(); // Car is moving forward on the ground.
        carRef.MoveBackward(); // Car is moving backward on the ground.
        
        IMoveable planeRef = new Airplane();
        planeRef.MoveForward(); // Airplane is moving forward on the ground.
        planeRef.MoveBackward(); // Airplane is moving backward on the ground.
        

        #endregion

        #region Q13

        /* What is the benefit of an interface inheriting other interfaces?
             Benefit:
                An interface can inherit from multiple interfaces to combine their capabilities.
                This allows a class that implements the derived interface to support all members
                from the parent interfaces, while keeping the design organized, reusable, and flexible.
         */

        #endregion

        #region Q14

        /* Compile Error
         NewShip newShip = new NewShip();
         newShip.MoveForward();
        */

        IMoveable newShip = new NewShip();
        newShip.MoveForward();

#endregion

        #endregion
        



    }
}