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
        List<Book> books =
        [

            new(
                "111",
                "Clean Code",
                ["Robert C. Martin"],
                new DateTime(2008, 8, 1),
                500m
            ),
            
            new(
                "222",
                "C# in Depth",
                ["Jon Skeet"],
                new DateTime(2019, 3, 15),
                700m
            )
        ];

        #region User-defined Delegate

        ProcessBooksUserDefined(books, BookFunctions.GetTitle);

        #endregion

        #region Built-in Delegate

        ProcessBooksBuiltIn(books, BookFunctions.GetTitle);

        #endregion

        #region Anonymous Method — ISBN

        ProcessBooksBuiltIn(books, book =>
        {
            return book.ISBN;
        });

        #endregion

        #region Lambda — PublicationDate

        ProcessBooksBuiltIn(books , book => book.PublicationDate.ToString());

        #endregion

        #region User-Defined Delegate 

        Order order = new Order
        {
            Id = 1,
            CustomerName = "Mohamed",
            Price = 500,
            Quantity = 3
        };
        decimal total = OrderFunctions.CalculateOrderPrice(order, OrderFunctions.CalculateTotal);
        decimal totalWithDiscount = OrderFunctions.CalculateOrderPrice(order, OrderFunctions.CalculateTotalWithDiscount);
        Console.WriteLine(total);
        Console.WriteLine(totalWithDiscount);

        #endregion


    }
}