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
    }
}