namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1 : Write a program that allows the user to enter a number then print it. 
            #region Question 1
            Console.WriteLine("Enter Number:");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Enter Invalid Number");
            }
            #endregion

            #region Question 2
            Console.Write("Enter a string: ");
            string? input = Console.ReadLine();
            try
            {
                int number = int.Parse(input!);
                Console.WriteLine($"Converted Number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException: The input contains non-numeric characters.");
            }
            #endregion
        }
    }
}
