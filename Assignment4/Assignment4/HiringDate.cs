namespace Assignment4;

public struct HiringDate
{
    public int Day { get; set; }
    
    public int Month { get; set; }
    
    public int Year { get; set; }

    public HiringDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Day:D2}/{Month:D2}/{Year:D2}";
    }
}