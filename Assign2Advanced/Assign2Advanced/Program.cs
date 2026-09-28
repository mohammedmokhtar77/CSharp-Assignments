namespace Assign2Advanced;

class Program
{
    
    public static void ProcessBooksUserDefined(List<Book> books, BookFunction bookFunction)
    {
        foreach (Book book in books)
        {
            Console.WriteLine(bookFunction(book));
        }
    }
    public static void ProcessBooksBuiltIn(List<Book> books, Func<Book, string> bookFunction)
    {
        foreach (Book book in books)
        {
            Console.WriteLine(bookFunction(book));
        }
    }
    static void Main(string[] args)
    {
    }
}