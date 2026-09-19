namespace Assignment6;

public class Duration
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    #region Constructors

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

    #endregion

    #region Override

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

    #endregion
    
    // Convert Duration to total seconds
    private int TotalSeconds()
    {
        return Hours * 3600 + Minutes * 60 + Seconds;
    }

    #region Operator Overloading

    // D3 = D1 + D2
    public static Duration operator +(Duration d1, Duration d2)
    {
        return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
    }

    // D3 = D1 + 7800
    public static Duration operator +(Duration d1, int seconds)
    {
        return new Duration(d1.TotalSeconds() + seconds);
    }

    // D3 = 666 + D3
    public static Duration operator +(int seconds, Duration d1)
    {
        return new Duration(seconds + d1.TotalSeconds());
    }

    // D3 = ++D1
    // Increase one minute
    public static Duration operator ++(Duration d)
    {
        return new Duration(d.TotalSeconds() + 60);
    }

    // D3 = --D2
    // Decrease one minute
    public static Duration operator --(Duration d)
    {
        return new Duration(Math.Max(0, d.TotalSeconds() - 60));
    }

    // D1 = D1 - D2
    public static Duration operator -(Duration d1, Duration d2)
    {
        return new Duration(Math.Max(0, d1.TotalSeconds() - d2.TotalSeconds()));
    }

    // D1 > D2
    public static bool operator >(Duration d1, Duration d2)
    {
        return d1.TotalSeconds() > d2.TotalSeconds();
    }

    // D1 < D2
    public static bool operator <(Duration d1, Duration d2)
    {
        return d1.TotalSeconds() < d2.TotalSeconds();
    }

    // D1 >= D2
    public static bool operator >=(Duration d1, Duration d2)
    {
        return d1.TotalSeconds() >= d2.TotalSeconds();
    }

    // D1 <= D2
    public static bool operator <=(Duration d1, Duration d2)
    {
        return d1.TotalSeconds() <= d2.TotalSeconds();
    }

    // if (D1)
    public static bool operator true(Duration d)
    {
        return d.TotalSeconds() > 0;
    }

    public static bool operator false(Duration d)
    {
        return d.TotalSeconds() == 0;
    }

    // Explicit conversion: Duration -> DateTime
    public static explicit operator DateTime(Duration d)
    {
        return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        // (year , month , day , hours , minutes , seconds)
    }

    #endregion
}