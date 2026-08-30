namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // Q1 : Write a program that allows the user to enter a number then print it. 
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

            #region Question 3

            /*
                Q3 : Write C# program that Perform a simple arithmetic 
                   operation with floating-point numbers And mention 
                   what will happen ? 
                       Answer: Floating-point numbers may not represent all decimal values with exact precision, 
                       so arithmetic operations can sometimes produce a value that is slightly different from the expected result 
                       due to floating-point precision limitations.
            */

            Console.Write("Enter first floating-point number: ");
            string? input1 = Console.ReadLine();
            Console.Write("Enter second floating-point number: ");
            string? input2 = Console.ReadLine();

            if (float.TryParse(input1, out float num1) && float.TryParse(input2, out float num2))
            {
                float sum = num1 + num2;
                float sub = num1 - num2;
                float multi = num1 * num2;

                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Subtract: {sub}");
                Console.WriteLine($"Multiply: {multi}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            #endregion

            #region Question 4

            // Q4: Write C# program that Extract a substring from a given string.
            Console.Write("Enter a string: ");
            string? input = Console.ReadLine();

            Console.Write("Enter start index: ");
            int startIndex = int.Parse(Console.ReadLine()!);

            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine()!);

            if (input != null &&
                startIndex >= 0 &&
                length >= 0 &&
                startIndex + length <= input.Length)
            {
                string substring = input.Substring(startIndex, length);
                Console.WriteLine($"Extracted: {substring}");
            }
            else
            {
                Console.WriteLine("Invalid start index or length.");
            }

            #endregion
        }
    }
}
