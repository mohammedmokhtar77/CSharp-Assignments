namespace Assign2Advanced;

class Program
{
    public static bool ValidateOrder(Order order, Predicate<Order> validationRule)
    {
        return validationRule(order);
    }

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

        Order order = new Order
        {
            Id = 1,
            CustomerName = "Mohamed",
            Price = 500,
            Quantity = 3
        };
        #region User-Defined Delegate 

        decimal total = OrderFunctions.CalculateOrderPriceUserDefined(order, OrderFunctions.CalculateTotal);
        decimal totalWithDiscount = OrderFunctions.CalculateOrderPriceUserDefined(order, OrderFunctions.CalculateTotalWithDiscount);
        Console.WriteLine(total);
        Console.WriteLine(totalWithDiscount);

        #endregion

        #region Func

        decimal totalFunc = OrderFunctions.CalculateOrderPriceFunc(order, OrderFunctions.CalculateTotal);
        decimal totalWithDiscountFunc = OrderFunctions.CalculateOrderPriceFunc(order, OrderFunctions.CalculateTotalWithDiscount);
        Console.WriteLine(totalFunc);
        Console.WriteLine(totalWithDiscountFunc);

        #endregion

        #region Predicate

        bool validQuantity = ValidateOrder(order, order => order.Quantity > 0);
        Console.WriteLine(validQuantity);
        bool validPrice = ValidateOrder(order, order => order.Price > 0);
        Console.WriteLine(validPrice);
        bool validCustomerName = ValidateOrder(order, order => !string.IsNullOrEmpty(order.CustomerName));
        Console.WriteLine(validCustomerName);

        #endregion




    }
}