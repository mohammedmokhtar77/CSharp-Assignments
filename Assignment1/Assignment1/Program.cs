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

            /*
                Q3 : Write C# program that Perform a simple arithmetic 
                   operation with floating-point numbers And mention 
                   what will happen ? 
                       Answer: Floating-point numbers may not represent all decimal values with exact precision, 
                       so arithmetic operations can sometimes produce a value that is slightly different from the expected result 
                       due to floating-point precision limitations.
            */
            #region Question 3

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
        }
    }
}
