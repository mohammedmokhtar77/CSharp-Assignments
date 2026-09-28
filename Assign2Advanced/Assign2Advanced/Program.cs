namespace Assign2Advanced;

class Program
{
    static void ProcessOrder(Order order, Action<Order> action)
    {
        Console.WriteLine($"Processing Order {order.Id}");
        action(order);
    } 

    static bool ValidateOrder(Order order, Predicate<Order> validationRule)
    {
        return validationRule(order);
    }

     static void ProcessBooksUserDefined(List<Book> books, BookFunction bookFunction)
    {
        foreach (Book book in books)
        {
            Console.WriteLine(bookFunction(book));
        }
    }
    static void ProcessBooksBuiltIn(List<Book> books, Func<Book, string> bookFunction)
    {
        foreach (Book book in books)
        {
            Console.WriteLine(bookFunction(book));
        }
    }
    static void Main()
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

        ProcessBooksBuiltIn(books , b => b.PublicationDate.ToString());

        #endregion

        Order order = new Order
        {
            Id = 1,
            CustomerName = "Mohammed",
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

        bool validQuantity = ValidateOrder(order, o => o.Quantity > 0);
        Console.WriteLine(validQuantity);
        bool validPrice = ValidateOrder(order, o => o.Price > 0);
        Console.WriteLine(validPrice);
        bool validCustomerName = ValidateOrder(order, o => !string.IsNullOrEmpty(o.CustomerName));
        Console.WriteLine(validCustomerName);

        #endregion

        #region Action

        ProcessOrder(order, o => Console.WriteLine(o.ToString()));
        ProcessOrder(order , OrderEventHandlers.SendOrderNotification);
        ProcessOrder(order, OrderEventHandlers.WriteOrderAudit);
        

        #endregion

        #region Events & Events Subscription

        OrderService orderService = new OrderService();
        orderService.OrderProcessed += OrderEventHandlers.PrintOrderProcessed;
        orderService.OrderProcessed += OrderEventHandlers.SendOrderNotification;
        orderService.OrderProcessed += OrderEventHandlers.WriteOrderAudit;
        orderService.OrderProcessed -= OrderEventHandlers.PrintOrderProcessed;
        orderService.ProcessOrder(order);

        #endregion

        

    }
}