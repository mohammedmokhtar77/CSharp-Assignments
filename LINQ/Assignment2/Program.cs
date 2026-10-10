using static Assignment2.ListGenerator;
namespace Assignment2;

class Program
{
    static void Main(string[] args)
    {
        #region Element Operators

        #region 1. Get first Product out of Stock
        
        var firstOutOfStockProduct = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
        Console.WriteLine(firstOutOfStockProduct);

        #endregion


        #endregion
    }
}