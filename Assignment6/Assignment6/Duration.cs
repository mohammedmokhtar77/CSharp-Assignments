namespace Assignment6;

public class Duration
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    // Constructor: Hours, Minutes, Seconds
    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    // Constructor: Total seconds
    public Duration(int totalSeconds)
    {
        Hours = totalSeconds / 3600;

        totalSeconds %= 3600;

        Minutes = totalSeconds / 60;

        Seconds = totalSeconds % 60;
    }

    // Override ToString()
    public override string ToString()
    {
        if (Hours > 0)
        {
            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
        }

        return $"Minutes :{Minutes}, Seconds :{Seconds}";
    }

    // Override Equals() ====> Value Equality
    public override bool Equals(object? obj)
    {
        if (obj is not Duration other)
            return false;

        return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
    }

    // Override GetHashCode() ===> USer Defined HashCode 
    public override int GetHashCode()
    {
        return HashCode.Combine(Hours, Minutes, Seconds);
    }
}