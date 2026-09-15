namespace Assignment5;

public class Vehicle : IVehicle
{
    public virtual void MoveForward()
    {
        Console.WriteLine("Vehicle is moving forward.");
    }

    public virtual void MoveBackward()
    {
        Console.WriteLine("Vehicle is moving backward.");
    }

    public virtual void MoveUp()
    {
        Console.WriteLine("Vehicle is moving up.");
    }

    public virtual void MoveDown()
    {
        Console.WriteLine("Vehicle is moving down.");
    }
}