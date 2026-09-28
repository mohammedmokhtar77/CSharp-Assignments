namespace Assign2Advanced;

public delegate string BookFunction(Book book);

public class BookFunctions
{
    public static string GetTitle(Book book)
    {
        return book.Title;
    }

    public static string GetAuthor(Book book)
    {
        return $"{string.Join(", ", book.Authors)}";
    }

    public static decimal GetPrice(Book book)
    {
        return book.Price;
    }
}