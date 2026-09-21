namespace Assignmet7;

public static class TextHelper
{
    // Normal
    // public static bool IsShorterThan( string text1, int length)
    // {
    //     return text1.Length < length;
    // }
    
    // Extension
    public static bool IsShorterThan(this string text1, int length)
    {
        return text1.Length < length;
    }

    public static string Repeat(this string value, int times)
    {
        int counter = 0;
        while (counter < times)
        {
            Console.Write(value);
            counter++;
        }

        return value;
    }
}