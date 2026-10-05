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

        #region Aggregate Operators (Eager / Immediate Exeecution)

        #region 1. Uses Count to get the number of odd numbers in the array 


        // int[] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // int countOddNumbers = Arr.Count(n => n % 2 != 0);
        // Console.WriteLine(countOddNumbers);

        #endregion

        #region 2. Return a list of customers and how many orders each has. 

        // var customerOrderCounts = CustomersList.Select(c => new { CustomerName = c.CustomerName, OrderCount = c.Orders.Count() });
        // foreach (var customerOrderCount in customerOrderCounts)
        // {
        //     Console.WriteLine(customerOrderCount.CustomerName + " has " + customerOrderCount.OrderCount + " orders.");
        // }
        

        #endregion

        #region 3. Return a list of categories and how many products each has

        // var categoryProductCounts = ProductsList.GroupBy(p => p.Category)
        //     .Select(g => new { CategoryName = g.Key, ProductCount = g.Count() });
        // foreach (var categoryProductCount in categoryProductCounts)
        // {
        //     Console.WriteLine($"{categoryProductCount.CategoryName}: {categoryProductCount.ProductCount}");
        // }


        #endregion

        #region 4. Get the total of the numbers in an array. 

        // int[] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var total = Arr.Sum();
        // Console.WriteLine(total);


        #endregion

        string[] words = File.ReadAllLines("dictionary_english.txt");
        
        #region 5. Get the total number of characters of all words in dictionary_english.txt. 
        
        // int totalCharacters = words.Sum(word => word.Length);
        // Console.WriteLine(totalCharacters);


        #endregion

        #region 6. Get the length of the shortest word in dictionary_english.txt

        // int shortestWordLength = words.Min(word => word.Length);
        // Console.WriteLine(shortestWordLength);

        #endregion

        #region 7. Get the length of the longest word in dictionary_english.txt

        // int longestWordLength = words.Max(word => word.Length);
        // Console.WriteLine(longestWordLength);

        #endregion
        
        #region 8. Get the average length of the words in dictionary_english.txt

        // int averageWordsLength =(int) words.Average(word => word.Length);
        // Console.WriteLine(averageWordsLength);

        #endregion

        #endregion
    }
}