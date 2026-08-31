using System.Globalization;

namespace Assignment2;

class Program
{
    static void Main(string[] args)
    {
        #region Question1
        
        /* 1- Write a program that takes a number from the user then print yes if 
        that number can be divided by 3 and 4 otherwise print no. */
        
        string? input = Console.ReadLine();
        
        if (int.TryParse(input, out int number))
        {
            if (number % 3 == 0 && number % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        #endregion

        #region Question2
        /*
         2- Write a program that allows the user to insert an integer then print 
            negative if it is negative number otherwise print positive.
         */
        string? input2 = Console.ReadLine();

        if (int.TryParse(input2, out int numberToCheck))
        {
            /* Console.WriteLine(
             (numberToCheck > 0 ? "Positive"
             : numberToCheck < 0 ? "Negative"
             : "Zero")); Ternary If */ 
            if (numberToCheck > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (numberToCheck < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }

        }
        else
        {
            Console.WriteLine("Invalid Input...");
        }
        #endregion
    }
}