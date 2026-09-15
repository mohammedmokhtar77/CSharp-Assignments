namespace Assignment5;

public class Car : IMoveable
{
    public void MoveForward()
    {
        Console.WriteLine("Car is moving forward on the ground.");
    }

    public void MoveBackward()
    {
        Console.WriteLine("Car is moving backward on the ground.");
    }
}