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
        
        // int[] arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var oddNumbersCount = arr.Count(x => x % 2 != 0);
        // Console.WriteLine(oddNumbersCount);

        #endregion

        #region 2. Return a list of customers and how many orders each has.
        
        // var customerCountOrders = CustomersList.Select(c => 
        //     new { 
        //         Customer = c, 
        //         OrdersCount = c.Orders.Count()
        //         
        //     }).ToList();
        // foreach (var customer in customerCountOrders)
        //     Console.WriteLine($"{customer.Customer}: {customer.OrdersCount}");
        

        #endregion

        #region 3. Return a list of categories and how many products each has 

        
        // var categoriesProductsCount = from p in ProductsList
        //                                     group p by p.Category into g
        //                                     select new {Category = g.Key, ProductCount = g.Count()};
        // foreach (var c in categoriesProductsCount) 
        //     Console.WriteLine($"{c.Category} - {c.ProductCount}");

        #endregion

        #region 4. Get the total of the numbers in an array.
        
        // var totalNumbers = arr.Sum();
        // Console.WriteLine(totalNumbers);

        #endregion

        #region 5. Get the total number of characters of all words in dictionary_english.txt

        string[] words = File.ReadAllLines("dictionary_english.txt");
        // var totalNumberOfCharacters = words.SelectMany(w => w)
        //                             .Count();
        // Console.WriteLine(totalNumberOfCharacters);


        #endregion

        #region 6. Get the length of the shortest word in dictionary_english.txt

        // var shortestWord = words.Min(x => x.Length);
        // Console.WriteLine(shortestWord);

        #endregion

        #region 7. Get the length of the longest word in dictionary_english.txt

        // var longestWord = words.Max(x => x.Length);
        // Console.WriteLine(longestWord);

        #endregion

        #region 8. Get the average length of the words in dictionary_english.txt 

        // var averageWords = words.Average(word => word.Length);
        // Console.WriteLine(averageWords);

        #endregion

        #region 9. Get the total units in stock for each product category.

        // var totalUnitsInStock =
        //     from p in ProductsList
        //     group p by p.Category into g
        //     select new
        //     {
        //         ProductCategory = g.Key,
        //         TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
        //     };
        // foreach (var item in totalUnitsInStock)
        //     Console.WriteLine($"{item.ProductCategory} : {item.TotalUnitsInStock}");

        #endregion

        #region 10. Get the cheapest price among each category's products

        // var cheapestPriceForCategory = from p in ProductsList
        //     group p by p.Category
        //     into g
        //     select new { ProuctCategory = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) };
        // foreach (var item in cheapestPriceForCategory)
        // {
        //     Console.WriteLine($"{item.ProuctCategory} : {item.CheapestPrice}");
        // }

        #endregion

        #region 11. Get the products with the cheapest price in each category

        // var cheapestProducts =
        //     from p in ProductsList
        //     group p by p.Category into g
        //     let cheapestPrice = g.Min(p => p.UnitPrice)
        //     from product in g
        //     where product.UnitPrice == cheapestPrice
        //     select new
        //     {
        //         ProductCategory = g.Key,
        //         ProductName = product.ProductName,
        //         Price = product.UnitPrice
        //     };
        // foreach (var product in cheapestProducts)
        // {
        //     Console.WriteLine($"Category: {product.ProductCategory},Product: {product.ProductName},Price: {product.Price}");
        // }

        #endregion

        #region 12. Get the most expensive price among each category's products.

        // var expensivePriceForCategory = from p in ProductsList
        //     group p by p.Category into g
        //         select new { Category = g.Key, ExpensivePrice = g.Max(p => p.UnitPrice) };
        // foreach (var item in expensivePriceForCategory)
        // {
        //     Console.WriteLine($"{item.Category} - {item.ExpensivePrice}");
        // }

        #endregion

        #region 13. Get the products with the most expensive price in each category

        // var expensiveProducts = from p in ProductsList
        //     group p by p.Category
        //     into g
        //     let ExpensivePrice = g.Max(p => p.UnitPrice)
        //     from product in g
        //     where product.UnitPrice == ExpensivePrice
        //     select new
        //     {
        //         ProductCategory = g.Key,
        //         ProductName = product.ProductName,
        //         Price = product.UnitPrice
        //     };
        // foreach (var product in expensiveProducts)
        // {
        //     Console.WriteLine($"Category: {product.ProductCategory},Product: {product.ProductName},Price: {product.Price}");
        // }


        #endregion

        #region 14. Get the average price of each category's products.

        // var averagePricePerCategory =
        //     from p in ProductsList
        //     group p by p.Category into g
        //     select new
        //     {
        //         ProductCategory = g.Key,
        //         AveragePrice = g.Average(p => p.UnitPrice)
        //     };
        //
        // foreach (var item in averagePricePerCategory)
        // {
        //     Console.WriteLine(
        //         $"Category: {item.ProductCategory}, Average Price: {item.AveragePrice:F2}");
        // }

        #endregion





        #endregion

        #region Set Operators

        #region 1. Find the unique Category names from Product List


        // var uniqueCategories = ProductsList.Select(x => x.Category)
        //     .Distinct().ToList();
        // foreach (var category in uniqueCategories)
        //     Console.WriteLine(category);

        #endregion

        #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

        // var uniqueLetters = ProductsList.Select(p =>p.ProductName[0])
        //     .Concat(CustomersList.Select(c => c.CustomerName[0]))
        //     .Distinct();
        // foreach (var item in uniqueLetters)
        //     Console.Write($"{item} ");

        #endregion

        #region 3. Create one sequence that contains the common first letter from both product and customer names.

        // var commonFirstLetter = ProductsList.Select(p => p.ProductName[0])
        //     .Intersect(CustomersList.Select(c => c.CustomerName[0]));
        // foreach (var letter in commonFirstLetter)
        // {
        //     Console.Write($"{letter} ");
        // }



        #endregion

        #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names. 

        // var uniqueFirstLetters = ProductsList
        //     .Select(p => p.ProductName[0])
        //     .Except(CustomersList.Select(c => c.CustomerName[0]));
        //
        // foreach (var letter in uniqueFirstLetters)
        // {
        //     Console.Write($"{letter} ");
        // }

        #endregion

        #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates 

        // var lastThreeCharacters = CustomersList
        //     .Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3))
        //     .Concat(ProductsList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)));
        //
        // foreach (var item in lastThreeCharacters)
        // {
        //     Console.WriteLine(item);
        // }

        #endregion
        
        

        #endregion

        #region  Partitioning Operators

        #region 1. Get the first 2 orders from customers in Germany

        // var firstTwoOrdersInGermany = 
        //     CustomersList.Where(c => c.Country == "Germany")
        //     .SelectMany(c => c.Orders)
        //     .Take(2);
        // foreach (var order in firstTwoOrdersInGermany)
        // {
        //     Console.WriteLine(order);
        // }


        #endregion

        #region 2. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array. 

        // int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var result = numbers.TakeWhile((num, index) => num > index);
        // foreach (var num in result)
        // {
        //     Console.Write($"{num} ");
        // }


        #endregion

        #region 3.Get the elements of the array starting from the first element divisible by 3. 
        
        // int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var result = numbers.SkipWhile(n => n % 3 != 0);
        // foreach (var number in result)
        // {
        //     Console.Write($"{number} ");
        // }

        #endregion

        #region 4. Get the elements of the array starting from the first element less than its position.

        // var result = numbers.SkipWhile((n, i) => n > i);
        // foreach (int number in result)
        // {
        //     Console.Write($"{number} ");
        // }
        
        #endregion

        #endregion

        #region Quantifiers

        #region 1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'. 

        // bool anyWordContainEi = words.Any(w => w.Contains("ei",StringComparison.OrdinalIgnoreCase));
        // Console.WriteLine(anyWordContainEi);

        #endregion

        #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

        // var productsWithAtLeastOneOutOfStock =
        //     ProductsList.GroupBy(p => p.UnitPrice)
        //         .Where(g => g.Any(p => p.UnitsInStock == 0));
        // foreach (var category in productsWithAtLeastOneOutOfStock)
        // {
        //     Console.WriteLine($"Category: {category.Key}");
        //
        //     foreach (var product in category)
        //     {
        //         Console.WriteLine($"  {product.ProductName} - Stock: {product.UnitsInStock}");
        //     }
        // }

        #endregion

        #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

        // var productsWithAllInStock =
        //     ProductsList.GroupBy(p => p.Category)
        //         .Where(g => g.All(p => p.UnitsInStock != 0));
        //
        // foreach (var category in productsWithAllInStock)
        // {
        //     Console.WriteLine($"Category: {category.Key}");
        //
        //     foreach (var product in category)
        //     {
        //         Console.WriteLine($"  {product.ProductName} - Stock: {product.UnitsInStock}");
        //     }
        // }

        #endregion
        
        #endregion

        #region Grouping Operators

        #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

        List<int> numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15];
        var result = from number in numbers
            group number by number % 5
            into g
            select g;
        foreach (var group in result)
        {
            Console.WriteLine($"Numbers with a reminder of {group.Key} when divided by 5:");
            foreach (var number in group)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }


        #endregion

        #endregion
    }
}
