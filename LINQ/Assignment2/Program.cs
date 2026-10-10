using static Assignment2.ListGenerator;
namespace Assignment2;

class Program
{
    static void Main(string[] args)
    {
        #region Element Operators

        #region 1. Get first Product out of Stock
        
        // var firstOutOfStockProduct = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
        // Console.WriteLine(firstOutOfStockProduct);

        #endregion

        #region 2. Return the first product whose Price > 1000.

        // var firstExpensiveProduct = ProductsList.FirstOrDefault(p => p.UnitPrice > 1_000);
        // if(firstExpensiveProduct !=null)
        //     Console.WriteLine(firstExpensiveProduct);
        // else
        //     Console.WriteLine("No product found");
        
        #endregion

        #region 3. Retrieve the second number greater than 5  
        
        // int[] arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        //
        // var secondNumberGreaterThanFive = arr.Where(n => n > 5)
        //     .Skip(1)
        //     .FirstOrDefault();
        // Console.WriteLine(secondNumberGreaterThanFive);


        #endregion
        
        

        #endregion

        #region Aggregate Operators

        #region 1. Uses Count to get the number of odd numbers in the array 
        
        int[] arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        var oddNumbersCount = arr.Count(x => x % 2 != 0);
        Console.WriteLine(oddNumbersCount);

        #endregion

        #region 2. Return a list of customers and how many orders each has.


        var customerCountOrders = CustomersList.Select(c => 
            new { 
                Customer = c, 
                OrdersCount = c.Orders.Count()
                
            }).ToList();
        foreach (var customer in customerCountOrders)
            Console.WriteLine($"{customer.Customer}: {customer.OrdersCount}");
        

        #endregion

        #endregion
    }
}