namespace Assign1Advanced;

public class Range<T> where T : IComparable<T>
{
    private T Min { get; set; }

    private T Max { get; set; }
    
    public Range(T min, T max)
    {
        Min = min;
        Max = max;
    }

    public bool IsInRange(T value)
    {
        return value.CompareTo(this.Min) >= 0 && value.CompareTo(this.Max) <= 0;
    }

    public dynamic Length()
    {
        return (dynamic)Max - (dynamic)Min;
    }
}