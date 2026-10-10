namespace Assignment2;

public class LettersComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if (x == null || y == null)
            return x == y;

        return SortCharacters(x) == SortCharacters(y);
    }

    public int GetHashCode(string obj)
    {
        return SortCharacters(obj).GetHashCode();
    }
    
    private string SortCharacters(string word)
    {
        return new string(word.OrderBy(c => c).ToArray());
    }
}