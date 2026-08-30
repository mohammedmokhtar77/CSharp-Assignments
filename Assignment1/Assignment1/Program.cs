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

            #region Question 7

            // 7- Write C# program that take two string variables and print them as one variable 
            Console.WriteLine("Enter First String");
            string? s1 = Console.ReadLine();

            Console.WriteLine("Enter Second String");
            string? s2 = Console.ReadLine();

            Console.WriteLine("1st Way (String Concatenation): " + s1 + " " + s2);
            Console.WriteLine("2nd Way (Composite Formatting): {0} {1}", s1, s2);
            Console.WriteLine($"3rd Way (String Interpolation): {s1} {s2}");

            #endregion

            #region Question 8

            /*8- Which of the following statements is correct about 
                    the C#.NET code snippet given below? 
                    a) A value 0 will be assigned to d. (False)
                    b) A value 1 will be assigned to d.  (True)
                    c) A value -1 will be assigned to d. (False)
                    d) The code reports an error. (False)
                    e) The code snippet will work correctly if ! is replaced by Not. (False)
                    */
            int d;
            d = Convert.ToInt32(!(30 < 20));  // ((false (bool)) ===> !(false) ===> true ====> ConvertToInt ===> 1)

            #endregion

            #region Question 9
            /*
             9- Which of the following is the correct output for the 
                C# code given below? 
                a) 6.5 1  (False)
                b) 6.5 0 (False)
                c) 6 0 (False)
                d) 6 1 (True)
                e) 6.5 6.5 (False)
            */

            Console.WriteLine(13 / 2 + " " + 13 % 2);

            // 13 / 2 = 6 because both operands are integers (integer division)
            // (13 % 2) = 1 because 1 is the remainder
            // Result: 6 1
            #endregion

            #region Question 10

            /*10-What will be the output of the C# code given below?  
                    a) 5 6 
                    b) 6 5 
                    c) 6 6 
                    d) 7 7
                    */
            int num = 1, z = 5;
            if (!(num <= 0)) // !(False) => True , 2 + 5 + " " + 7 => 7 + " " + 7
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            /*
                 num <= 0 → false
                 !false → true, so the if block executes
                 ++num → 2 (pre-increment)
                 z++ → 5, then z becomes 6 (post-increment)
                 ++z → 7
                 Output: 7 7
            */

            #endregion

        }
    }
}
