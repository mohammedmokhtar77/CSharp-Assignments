using System.Globalization;

namespace Assignment2;

class Program
{
    static void Main()
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
        
        #region Question3
        
        /*3- Write a program that takes 3 integers from the user then prints the max 
             element and the min element. */
        
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine()!);
        
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine()!);
        
        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine()!);
        
        int max = Math.Max(num1, Math.Max(num2, num3));
        int min = Math.Min(num1, Math.Min(num2, num3));
        
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}"); // Can Use If Conditions But I Preferred Math
        #endregion
        
        #region Question4
        Console.Write("Enter the number: ");
        string? input3 = Console.ReadLine();
        
        if (int.TryParse(input3, out int num))
        {
            Console.WriteLine(num % 2 == 0 ? $"{num} Is Even" : $"{num} Is Odd");
        }
        else
        {
            Console.WriteLine("Invalid input...");
        }
        #endregion
        
        #region Question5
        /*5- Write a program that takes character from the user then if it is a 
        vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).*/
        Console.Write("Enter a character: ");
        char ch = char.Parse(Console.ReadLine()!);
        ch = char.ToLower(ch);
        
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine("Vowel");
        }
        else
        {
            Console.WriteLine("Consonant");
        }
        
        #endregion
        
        #region Question6
        /*6- Write a program that allows the user to insert an integer then print 
            all numbers between 1 to that number.*/
        
        Console.Write("Enter an Integer: ");
        string? input4 = Console.ReadLine();
        
        if (int.TryParse(input4, out int limit) && limit >= 1)
        {
            for (int i = 1; i <= limit; i++)
            {
                Console.Write($"{i} ");
            }
        }
        else
        {
            Console.WriteLine("Invalid input...");
        }
        
        #endregion
        
        #region Question7
        
        /*7- Write a program that allows the user to insert an integer then  
            print a multiplication table up to 12. */
        Console.Write("Enter an Integer: ");
        string? input5 = Console.ReadLine();
        
        if (int.TryParse(input5, out int numberToMultiply))
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"{numberToMultiply * i} ");
            }
        }
        else
            Console.WriteLine("Invalid input...");
        #endregion
        
        #region Question8
        
        /*8- Write a program that allows to user to insert number then print all 
             even numbers between 1 to this number*/
        Console.Write("Enter a number: ");
        string? input6 = Console.ReadLine();
        
        if (int.TryParse(input6, out int numberToDivide))
        {
            for (int i = 2; i <= numberToDivide; i+=2)
                    Console.Write($"{i} ");
        }
        else
            Console.WriteLine("Invalid input...");
        #endregion
        
        #region Question9
        
        /*9- Write a program that takes two integers then prints the power.*/
        Console.Write("Enter the base number: ");
        string? baseInput = Console.ReadLine();
        
        Console.Write("Enter the exponent number: ");
        string? exponentInput = Console.ReadLine();
        
        if (int.TryParse(baseInput, out int baseNumber) && int.TryParse(exponentInput, out int exponentNumber))
        {
            double result = Math.Pow(baseNumber, exponentNumber);
            Console.WriteLine($"{baseNumber} ^ {exponentNumber} is: {result}");
        }
        else
            Console.WriteLine("Invalid input...");
        
        #endregion
        
        #region Question10
        
        /*
        10- Write a program to enter marks of five subjects and calculate
        total, average and percentage.
        */
        
        Console.Write("Enter marks of five subjects:");
        
        string[] marksInput = Console.ReadLine()!.Split(' '); // (!) ===> I'm Sure that input will not be null.
        int[] marks = Array.ConvertAll(marksInput, int.Parse);
        
        int total = marks[0] + marks[1] + marks[2] + marks[3] + marks[4];
        double average = total / 5.0;
        double percentage = (total / 500.0) * 100; // Assuming each subject is out of 100 marks.
        
        Console.WriteLine($"Total Marks = {total}");
        Console.WriteLine($"Average Marks = {average}");
        Console.WriteLine($"Percentage = {percentage}");
        #endregion
        
        #region Question11
        /*
        11- Write a program to input the month number and print
        the number of days in that month.
        */
        
        Dictionary<int, int> monthDays = new()
        {
            { 1, 31 },{ 2, 28 }, { 3, 31 }, { 4, 30 }, { 5, 31 }, { 6, 30 },
            { 7, 31 }, { 8, 31 }, { 9, 30 }, { 10, 31 }, { 11, 30 }, { 12, 31 }
        };
        
        Console.Write($"Enter the month number : ");
        
        if (int.TryParse(Console.ReadLine() , out int monthNumber))
        {
            if (monthDays.TryGetValue(monthNumber , out int days))
                Console.WriteLine($"Days In Month {monthNumber} is: {days}");
            else
                Console.WriteLine("Invalid month number.");
        }
        else
            Console.WriteLine("Invalid Input...");
        #endregion
        
        #region Question12
        
        /*
        12- Write a program to create a Simple Calculator.
        */
        
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine()!);
        
        Console.Write("Enter operator (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine()!);
        
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine()!);
        
        switch (operation)
        {
            case '+':
                Console.WriteLine($"Result: {firstNumber + secondNumber}");
                break;
            case '-':
                Console.WriteLine($"Result: {firstNumber - secondNumber}");
                break;
            case '*':
                Console.WriteLine($"Result: {firstNumber * secondNumber}");
                break;
            case '/':
                if (secondNumber != 0)
                    Console.WriteLine($"Result: {firstNumber / secondNumber}");
                else
                    Console.WriteLine("Cannot divide by zero.");
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
        #endregion
        
        #region Question13
        /*13- Write a program to allow the user to enter a string and print the REVERSE of it. */
        Console.Write("Enter a string: ");
        string? inputString = Console.ReadLine();
        if (inputString != null)
            for (int i = inputString.Length - 1; i >= 0; i--)
                Console.Write(inputString[i]);
        
        /* Another Solution Using Built-in Methods
        char[] chars = inputString.ToCharArray();
        Array.Reverse(c);
        Console.WriteLine(new string(chars));*/
        #endregion
        
        #region Question14
        
        /*
        14- Write a program to allow the user to enter an int
        and print the REVERSED of it.
        */
        
        Console.Write("Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out int numberToReverse)) // Ex: 1234 => 4321
        {
            int reversed = 0;
            while (numberToReverse != 0)
            {
                int digit = numberToReverse % 10; // 1234 % 10 = 4 , 123 % 10 = 3 , 12 % 10 = 2 , 1 % 10 = 1
                reversed = reversed * 10 + digit; // 0 * 10 + 4 = 4 , 4 * 10 + 3 = 43 , 43 * 10 + 2 = 432 , 432 * 10 + 1 = 4321
                numberToReverse /= 10; // 1234 / 10 = 123 , 123 / 10 = 12 , 12 / 10 = 1 , 1 / 10 = 0
            }
            Console.WriteLine($"Reversed: {reversed}");
        }
        else
            Console.WriteLine("Invalid input.");
        
        
        #endregion
        
        #region Question15
        
        /*
        15- Write a program in C# Sharp to find prime numbers within a range of numbers.
        */
        
        Console.Write("Input starting number of range: ");
        int start = int.Parse(Console.ReadLine()!);
        
        Console.Write("Input ending number of range: ");
        int end = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine($"The prime numbers between {start} and {end} are:");
        
        for (int numberP = start; numberP <= end; numberP++)
        {
            if (numberP < 2)
                continue;
            bool isPrime = true;
            for (int i = 2; i < numberP; i++)
            {
                if (numberP % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.Write($"{numberP} ");
        }
        
        #endregion
        
        #region Question16
        /*
        16- Write a program in C# Sharp to convert a decimal number
        into binary without using an array.
        */
        Console.Write("Enter a number to convert: ");
        if (int.TryParse(Console.ReadLine(), out int numberToConvert))
        {
            string binary = Convert.ToString(numberToConvert, 2); // (number , base)
            Console.WriteLine($"The Binary of {numberToConvert} is {binary}.");
        }
        else
            Console.WriteLine("Invalid input...");
        
        #endregion
        
        #region Question17
        /*
         17- Create a program that asks the user to input three points (x1, y1), 
            (x2, y2), and (x3, y3), and determines whether these points lie on a 
            single straight line.
         */
        Console.Write("Enter the coordinates of Point 1 (x1 , y1): ");
        string[] point1Input = Console.ReadLine()!.Split(' ');
        double[] point1 = Array.ConvertAll(point1Input, double.Parse);
        Point p1 = new Point(){X = point1[0], Y = point1[1]}; // Object Initializer
        
        Console.Write("Enter the coordinates of Point 2 (x2 , y2): ");
        string[] point2Input = Console.ReadLine()!.Split(' ');
        double[] point2 = Array.ConvertAll(point2Input, double.Parse);
        Point p2 = new Point(){X = point2[0], Y = point2[1]};
        
        Console.Write("Enter the coordinates of Point 3 (x3 , y3): ");
        string[] point3Input = Console.ReadLine()!.Split(' ');
        double[] point3 = Array.ConvertAll(point3Input, double.Parse);
        Point p3 = new Point(){X = point3[0], Y = point3[1]};
        
        if ((p2.Y - p1.Y) * (p3.X - p1.X) ==  (p3.Y - p1.Y) * (p2.X - p1.X))
            Console.WriteLine("The points lie on a single straight line.");
        else
            Console.WriteLine("The points do not lie on a single straight line.");
        #endregion
        
        #region Question18
        /*
        18- Write a program to calculate the efficiency of a worker
        based on the time taken to complete a task.
        */
        Console.Write("Enter the time taken in hours: ");
        if (double.TryParse(Console.ReadLine(), out double hours))
        {
            if (hours >= 2 && hours < 3) 
                Console.WriteLine("Highly Efficient");
            else if (hours >= 3 && hours < 4)
                Console.WriteLine("Increase your speed");
            else if (hours >= 4 && hours <= 5)
                Console.WriteLine("You need training to improve your speed");
            else if (hours > 5)
                Console.WriteLine("You need to leave the company");
            else
                Console.WriteLine("Invalid time.");
        }
        else
            Console.WriteLine("Invalid input.");
        #endregion
        
        #region Question19
        
        /*
        19- Write a program that prints an identity matrix using for loop.
        */
        
        Console.Write("Enter the size of the identity matrix: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                    Console.Write(row == column ? "1 " : "0 ");
                
                Console.WriteLine(); // To move to the next line after each row
            }
        }
        else
            Console.WriteLine("Invalid input...");
        
        #endregion
        
        #region Question20
        /*20- Write a program in C# Sharp to find the sum of all elements of the array.*/
        int[] array = { 1, 2, 3, 4, 5 };
        int sum = array.Sum();
        Console.WriteLine($"The sum of the array is: {sum}");
        #endregion

        #region Question21

        /* 21- Write a program in C# Sharp to merge two arrays of the same size 
                sorted in ascending order. 
                Time Complexity : O(n log n) */
        int[] arr1 = { 9, 7, 12, 20, 5 };
        int[] arr2 = { 8, 15, 3, 10, 6 };
        Array.Sort(arr1);
        Array.Sort(arr2);
        
        int[] mergedArray = arr1.Concat(arr2).ToArray();
        Array.Sort(mergedArray);
        foreach (int i in mergedArray)
        {
            Console.Write(i + " ");
        }
            /*
             * Another Solution Merge Algorithm With Time Complexity O(n)
             *  int[] arr1 = { 5, 7, 9, 12, 20 };
                int[] arr2 = { 3, 6, 8, 10, 15 };

                int[] mergedArray = new int[arr1.Length + arr2.Length];

                int i = 0, j = 0, k = 0;

                while (i < arr1.Length && j < arr2.Length)
                {
                    if (arr1[i] < arr2[j])
                        mergedArray[k++] = arr1[i++];
                    else
                        mergedArray[k++] = arr2[j++];
                }

                while (i < arr1.Length)
                    mergedArray[k++] = arr1[i++];

                while (j < arr2.Length)
                    mergedArray[k++] = arr2[j++];

                foreach (int number in mergedArray)
                {
                    Console.Write(number + " ");
                }
             */
        #endregion

        #region Question22
        /*22- Write a program in C# Sharp to count the frequency of each element of an array. */
        int[] arr = { 1, 2, 3, 2, 1, 4, 5, 3, 2 };
        foreach (int i in arr)
        {
            Console.WriteLine($"{i} occurs {arr.Count(x => x == i)} times"); // lambda expression
        }
        #endregion
        
        #region Question23

        /*23- Write a program in C# Sharp to find maximum and minimum element in an array.*/

        int[] arre = { 10, 5, 20, 3, 15 };

        int maximum = arre.Max();
        int minimum = arre.Min();

        Console.WriteLine($"Maximum element: {maximum}");
        Console.WriteLine($"Minimum element: {minimum}");

        #endregion
    }
}