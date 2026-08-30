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

            #region Question 5

            /* Q5: Write C# program that Assigning one value type 
                variable to another and modifying the value of one variable and mention what will happen?
                Answer:Since int is a value type, assigning x to y copies the value.
                       Therefore, modifying x does not affect y.
                       The output will be:
                       X: 5    Y: 10  
                */

            int x = 10;
            int y = x;
            x = 5;
            Console.WriteLine($"X: {x} \t Y: {y}");
            #endregion

            #region Question 6
            /*
            Q6: Write C# program that Assigning one reference type
            variable to another and modifying the object through
            one variable and mention what will happen.

            Answer:
            Since Person is a reference type, assigning p1 to p2 makes
            both variables refer to the same object. Therefore, modifying
            the object through p1 will also affect p2.
            */

            Employee e1 = new Employee() { Name = "Mohammed" };
            Employee e2 = new Employee();
            e2.Name = "Mokhtar";
            e2 = e1;
            e2.Name = "Omar";
            Console.WriteLine($"e1 : {e1.Name} \t e2 : {e2.Name}");
            #endregion
        }
    }
}
