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

        var firstExpensiveProduct = ProductsList.FirstOrDefault(p => p.UnitPrice > 1_000);
        if(firstExpensiveProduct !=null)
            Console.WriteLine(firstExpensiveProduct);
        else
            Console.WriteLine("No product found");
        
        #endregion


        #endregion
    }
}