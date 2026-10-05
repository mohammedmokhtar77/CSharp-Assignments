using static Assignment1.ListGenerator;
namespace Assignment1;

class Program
{
    static void Main(string[] args)
    {
        #region Restriction Operators

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
    }
}