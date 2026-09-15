namespace Assignment5;

public class Ship : IMoveable
{
    public void MoveForward()
    {
        Console.WriteLine("Ship is moving forward on the sea.");
    }

    public void MoveBackward()
    {
        Console.WriteLine("Ship is moving backward on the sea.");
    }
}