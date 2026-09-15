namespace Assignment5;

public class NewShip : IMoveable
{
    void IMoveable.MoveForward()
    {
        Console.WriteLine("Ship is moving forward on the sea.");
    }

    public void MoveBackward()
    {
        Console.WriteLine("Ship is moving backward on the sea.");
    }
}