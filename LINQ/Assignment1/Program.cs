using static Assignment1.ListGenerator;
namespace Assignment1;

class Program
{
    static void Main(string[] args)
    {
        #region Restriction Operators (Deferred Execution)

        #region 1. Find all products that are out of stock.
        
        // var productsOutOfStock = ProductsList.Where(p => p.UnitsInStock == 0);
        // foreach (var product in productsOutOfStock)
        //     Console.WriteLine(product);
        
        #endregion

        #region 2. Find all products that are in stock and cost more than 3.00 per unit. 

        // var productsInStockAndCostMoreThan3 = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
        // foreach (var product in productsInStockAndCostMoreThan3)
        //     Console.WriteLine(product);
        
        #endregion

        #region 3. Returns digits whose name is shorter than their value. 
        
        // String [] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}; 
        // var digitsShorterThanValue = Arr.Where(d => d.Length < Array.IndexOf(Arr , d));
        // foreach (var digit in digitsShorterThanValue)
        // {
        //     Console.WriteLine(digit);
        // }
        
        #endregion
        #endregion

        #region Element Operators (Eager / Immediate Execution)

        #region 1. Get first Product out of Stock

        // var firstProductOutOfStock = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
        // Console.WriteLine(firstProductOutOfStock);
        
        #endregion

        #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

        // var firstProductPriceGreaterThan1000 = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
        // Console.WriteLine(firstProductPriceGreaterThan1000);

        #endregion

        #region 3. Retrieve the second number greater than 5  

        // int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var secondNumberGreaterThan5 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
        // Console.WriteLine(secondNumberGreaterThan5);

        #endregion

        #endregion
    }
}