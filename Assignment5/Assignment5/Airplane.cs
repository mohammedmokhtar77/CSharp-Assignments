namespace Assignment5;

public class Airplane : IMoveable, IFlyable
{
    public void MoveForward()
    {
        Console.WriteLine("Airplane is moving forward in the air.");
    }

    public void MoveBackward()
    {
        Console.WriteLine("Airplane is moving backward in the air.");
    }

    public void MoveUp()
    {
        Console.WriteLine("Airplane is moving up in the air.");
    }

    public void MoveDown()
    {
        Console.WriteLine("Airplane is moving down in the air.");
    }
}