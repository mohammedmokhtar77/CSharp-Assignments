using static Assignment1.ListGenerator;
namespace Assignment1;

class Program
{
    static void Main()
    {
        #region Restriction Operators (Deferred Execution)

        #region 1. Find all products that are out of stock.
        
         var productsOutOfStock = ProductsList.Where(p => p.UnitsInStock == 0);
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

        // string[] words = File.ReadAllLines("dictionary_english.txt");
        
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

        #region Ordering Operators (Deferred Execution)

        #region 1. Sort a list of products by name

        // var sortedProductsByName = ProductsList.OrderBy(p => p.ProductName);
        // foreach (var product in sortedProductsByName)
        // {
        //     Console.WriteLine(product);
        // }

        #endregion

        #region  2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

        // String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
        //
        // var sortedWordsCaseInsensitive = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
        // foreach (var word in sortedWordsCaseInsensitive)
        // {
        //     Console.WriteLine(word);
        // }


        #endregion

        #region 3. Sort a list of products by units in stock from highest to lowest.

        // var sortedProductsByUnitsInStock = ProductsList.OrderByDescending(p => p.UnitsInStock);
        // foreach (var product in sortedProductsByUnitsInStock)
        // {
        //     Console.WriteLine(product);
        // }


        #endregion

        #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

        // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        // var sortedDigitsByLengthThenAlphabetically = Arr.OrderBy(d => d.Length)
        //                                                                     .ThenBy(d => d);
        // foreach (var d in sortedDigitsByLengthThenAlphabetically)
        // {
        //     Console.WriteLine(d);
        // }
        
        #endregion
       
        // string [] arr = ["aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"]; 

        #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array. 
        
        // var sortWordsByLengthThenCaseInsensitive = arr.OrderBy(word => word.Length)
        //                                         .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
        // foreach (var word in sortWordsByLengthThenCaseInsensitive)
        // {
        //     Console.WriteLine(word);
        // }


        #endregion

        #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

        // var sortedProductsByCategoryThenUnitPrice = ProductsList.OrderByDescending(p => p.Category)
        //     .ThenByDescending(p => p.UnitPrice);
        // foreach (var product in sortedProductsByCategoryThenUnitPrice)
        // {
        //     Console.WriteLine(product);
        // }

        #endregion

        #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array. 

        // var sortWordsDescendingByLengthThenCaseInsensitive = Arr.OrderByDescending(word => word.Length)
        //                                         .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);
        // foreach (var word in sortWordsDescendingByLengthThenCaseInsensitive)
        // {
        //     Console.WriteLine(word);
        // }

        #endregion

        #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array. 

        // string[] arr = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
        // var result = arr
        //     .Where(word => char.ToLower(word[1]) == 'i')
        //     .Reverse();
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item);
        // }


        #endregion


        #endregion

        #region Transformation Operators (Deferred Execution)

        #region 1. Return a sequence of just the names of a list of products.

        // var prouductNames = ProductsList.Select(p => p.ProductName);
        // foreach (var name in prouductNames)
        //     Console.WriteLine(name);


        #endregion

        #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types). 

        // string[] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};
        // var upperLowerWords = words.Select(word => new { UpperCase = word.ToUpper(), LowerCase = word.ToLower() });
        // foreach (var word in upperLowerWords)
        // {
        //     Console.WriteLine($"Uppercase: {word.UpperCase}, Lowercase: {word.LowerCase}");
        // }
        


        #endregion

        #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

        // var productProperties = ProductsList.Select(p => new
        // {
        //     ProductName = p.ProductName,
        //     Category = p.Category,
        //     Price = p.UnitPrice
        // });
        // foreach (var product in productProperties)
        // {
        //     Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, Price: {product.Price}");
        // }

        #endregion

        #region 4. Determine if the value of int in an array match their position in the array. 


        // int[] arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var matchingPositions = arr.Select((value, i) => new { Value = value, Index = (i == value) });
        // foreach (var match in matchingPositions)
        // {
        //     Console.WriteLine($"Value: {match.Value}, Index: {match.Index}");
        // }


        #endregion

        #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB

        // int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 }; 
        // int[] numbersB = { 1, 3, 5, 7, 8 };
        //
        // var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new { A = a, B = b })
        //     .Where(pair => pair.A < pair.B);
        // foreach (var pair in pairs)
        //     Console.WriteLine($"{pair.A} is less than {pair.B}");

        #endregion

        #region 6. Select all orders where the order total is less than 500.00.


        // var ordersLessThan500 = CustomersList.SelectMany(c => c.Orders, (c, o) => new { Customer = c, Order = o })
        //     .Where(c => c.Order.Total < 500.00m);
        // foreach (var order in ordersLessThan500)
        // {
        //     Console.WriteLine(order.Customer.CustomerName + " has an order with total less than 500.00: " + order.Order.Total);
        // }

        #endregion

        #region 7. Select all orders where the order was made in 1998 or later.

        var ordersFrom1998OrLater = CustomersList.SelectMany(c => c.Orders, (c, o) => new { Customer = c, Order = o })
            .Where(c => c.Order.OrderDate.Year >= 1998);
        foreach (var order in ordersFrom1998OrLater)
        {
            Console.WriteLine($"{order.Customer.CustomerName} has an order from {order.Order.OrderDate.ToShortDateString()} with total {order.Order.Total}");
        }

        #endregion

        #endregion
    }
}