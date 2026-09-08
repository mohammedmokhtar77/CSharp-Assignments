namespace Assignment3;

enum WeekDays
{
    Monday , Tuesday , Wednesday , Thursday , Friday , Saturday , Sunday
}

enum Season
{
    Spring, Summer, Autumn, Winter
}

[Flags]
enum Permissions
{
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    Execute = 8
}

enum Colors
{
    Red,
    Green,
    Blue
}
class Program
{
    static void Main(string[] args)
    {
        #region Functions

        #region Question1

        /*
        1- Explain the difference between passing value type parameters
        by value and by reference then write a suitable C# example.
        */

        // Pass by Value
        static void PassByValue(int number)
        {
            number = 100;
        }

        // Pass by Reference
        static void PassByReference(ref int number)
        {
            number = 100;
        }

        int x = 10;
        int y = 10;

        PassByValue(x);
        PassByReference(ref y);

        Console.WriteLine($"After Pass By Value: {x}"); // Still 10 
        Console.WriteLine($"After Pass By Reference: {y}"); // Changed to 100

        #endregion

        #region Question2

        /*2- Explain the difference between passing (Reference type parameters)
         by value and by reference then write a suitable c# example */
        
        // Pass by valu
        static void ChangeName(Person person)
        {
            person.Name = "Ahmed";
        }
        Person p = new Person();
        p.Name = "Mohammed";
        ChangeName(p);
        Console.WriteLine(p.Name); // Ahmed
        
        // Pass by Reference
        static void ChangePerson(ref Person person)
        {
            person = new Person();
            person.Name = "Ahmed";
        }
        Person p1 = new Person();
        p1.Name = "Mohammed";
        ChangePerson(ref p1);
        Console.WriteLine(p1.Name); // Ahmed

        #endregion

        #region Question3

        // /*3- Write a c# Function that accept 4 parameters from user and 
        //      return result of summation and subtracting of two numbers */
        // static (int sum, int sub) Calc(int num1, int num2, int num3, int num4)
        // {
        //     int sum = num1 + num2;
        //     int sub = num3 - num4;
        //     return (sum, sub);
        // }
        //
        // Console.Write("Enter 4 Numbers: ");
        // int[] nums = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
        // (int sum, int sub) res = Calc(nums[0], nums[1], nums[2], nums[3]);
        // Console.WriteLine($"Sum: {res.sum} , Sub: {res.sub}");

        #endregion

        #region Question4

        // /*4- Write a program in C# Sharp to create a function to calculate the sum of 
        //         the individual digits of a given number. Output should be like
        //          Enter a number: 25 ,The sum of the digits of the number 25 is: 7 */
        //
        // static int SumOfDigits(int number)
        // {
        //     int sum = 0;
        //     while (number != 0)
        //     {
        //         sum += number % 10; // sum = sum + (number % 10) 
        //         number /= 10; // number = number / 10
        //     }
        //
        //     return sum;
        // }
        // Console.Write("Enter a number: ");
        // int number = int.Parse(Console.ReadLine()!);
        // int result = SumOfDigits(number); // 25 % 10 = 5, sum = 0 + 5 = 5 , number = 25 / 10 = 2, 2 % 10 = 2 , sum = 5 + 2 = 7;  
        //
        // Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
        #endregion

        #region Question5

        /*5- Create a function named "IsPrime", which receives an integer number 
            and retuns true if it is prime, or false if it is not: */
        // static bool IsPrime(int number)
        // {
        //     if (number < 2)
        //         return false;
        //     for (int i = 2; i * i <= number; i++)
        //     {
        //         if (number % i == 0)
        //             return false;
        //     }
        //     return true;
        // }
        //
        // Console.Write("Enter a number: ");
        // if (int.TryParse(Console.ReadLine()!, out int number))
        //     Console.WriteLine(IsPrime(number));
        // else
        //     Console.WriteLine("Invalid input. Please enter a valid integer.");
        #endregion
        
        #region Question6

        /*6- Create a function named MinMaxArray, to return the minimum and 
            maximum values stored in an array, using reference parameters */
        // static void MinMaxArray(int[] array, out int min, out int max)
        // {
        //     min = array[0];
        //     max = array[0];
        //
        //     for (int i = 1; i < array.Length; i++)
        //     {
        //         if (array[i] < min)
        //             min = array[i];
        //
        //         if (array[i] > max)
        //             max = array[i];
        //     }
        //     // I can Use Arr.Min() and Arr.Max() methods to get the min and max values in the array
        // }
        //
        // Console.Write("Enter array elements: ");
        // int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        //
        // MinMaxArray(numbers, out int min, out int max);
        //
        // Console.WriteLine($"Minimum = {min}");
        // Console.WriteLine($"Maximum = {max}");

        #endregion

        #region Question7

        /*7- Create an iterative (non-recursive) function to calculate the factorial of 
            the number specified as parameter */
        // static long Factorial(int n)
        // {
        //     long result = 1;
        //     for (int i = 1; i <= n; i++)
        //     {
        //         result *= i;
        //     }
        //     return result;
        // }
        //
        // Console.Write("Enter a number: ");
        // if (int.TryParse(Console.ReadLine()!, out int number))
        //     Console.WriteLine($"The factorial of {number} is: {Factorial(number)}");
        // else
        //     Console.WriteLine("Invalid input. Please enter a valid integer.");

        #endregion

        #region Question8

        // /*8- Create a function named "ChangeChar" to modify a letter in a certain 
        //      position (0 based) of a string, replacing it with a different letter */
        //
        // static string ChangeChar(string str, int pos, char newChar)
        // {
        //     char[] characters = str.ToCharArray();
        //     characters[pos] = newChar;
        //     return new string(characters);
        // }
        //
        // Console.Write("Enter a string: ");
        // string text = Console.ReadLine()!;
        //
        // Console.Write("Enter position: ");
        // int position = int.Parse(Console.ReadLine()!);
        //
        // Console.Write("Enter new character: ");
        // char newChar = char.Parse(Console.ReadLine()!);
        //
        // string result = ChangeChar(text, position, newChar);
        // Console.WriteLine($"Modified string: {result}");

#endregion

        #endregion

        #region Question1

        // /*
        //  1. Create an enum called "WeekDays" with the days of the week 
        //     (Monday to Sunday) as its members. Then, write a C# program that 
        //     prints out all the days of the week using this enum.
        //  */
        //
        // foreach (WeekDays day in Enum.GetValues<WeekDays>())
        // {
        //     Console.WriteLine(day);
        // }

        #endregion

        #region Question2

        // /*2. Define a struct "Person" with properties "Name" and "Age". Create an 
        //     array of three "Person" objects and populate it with data. Then, write 
        //     a C# program to display the details of all the persons in the array. */
        //
        // SPerson[] persons =
        // {
        //     new SPerson("Ali", 23),
        //     new("Mohammed", 20),
        //     new("Nasser", 5)
        // };
        //
        // foreach (SPerson person in persons)
        // {
        //     Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        // }

        #endregion

        #region Question3

        /*3. Create an enum called "Season" with the four seasons (Spring, 
            Summer, Autumn, Winter) as its members. Write a C# program that 
            takes a season name as input from the user and displays the 
            corresponding month range for that season. Note range for seasons ( 
            spring march to may , summer june to august , autumn September to 
            November , winter December to February) */
        // Console.Write("Enter a season: ");
        // string input = Console.ReadLine()!;
        //
        // if (Enum.TryParse(input, true, out Season season)) // true means ignore Case
        // {
        //     switch (season)
        //     {
        //         case Season.Spring:
        //             Console.WriteLine("Spring: March to May");
        //             break;
        //
        //         case Season.Summer:
        //             Console.WriteLine("Summer: June to August");
        //             break;
        //
        //         case Season.Autumn:
        //             Console.WriteLine("Autumn: September to November");
        //             break;
        //
        //         case Season.Winter:
        //             Console.WriteLine("Winter: December to February");
        //             break;
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Invalid season.");
        // }
        

        #endregion

        #region Question4

        // /*4- Assign the following Permissions (Read, write, Delete, Execute) in a 
        //     form of Enum. 
        //     ● Create Variable from previous Enum to Add and Remove 
        //     Permission from variable, check if specific Permission is 
        //     existed inside variable */
        //
        // Permissions userPermissions = Permissions.None;
        //
        // // Add Permissions ( | ----> BitWise OR)
        // userPermissions |= Permissions.Read;
        // userPermissions |= Permissions.Write;
        // userPermissions |= Permissions.Execute;
        //
        // Console.WriteLine($"User Permissions: {userPermissions}");
        // // Check if Permission Exists
        // if((userPermissions & Permissions.Read) == Permissions.Read)
        //     Console.WriteLine("Read permission exists");
        // // Remove Permission ( & ~ ----> BitWise AND with NOT)
        // userPermissions &= ~Permissions.Write;
        // Console.WriteLine($"User Permissions after removing Write: {userPermissions}");

        #endregion

        #region Question5

        // /*5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) 
        //     as its members. Write a C# program that takes a color name as input from 
        //     the user and displays a message indicating whether the input color is a 
        //     primary color or not. */
        // Console.Write("Enter a color: ");
        // string input = Console.ReadLine()!;
        //
        // if (Enum.TryParse(input, true, out Colors color))
        // {
        //     Console.WriteLine($"{color} is a primary color.");
        // }
        // else
        // {
        //     Console.WriteLine($"{input} is not a primary color.");
        // }
        

        #endregion

        #region Question6

        // /* 6. Create a struct called "Point" to represent a 2D point with properties
        //  "X" and "Y". Write a C# program that takes two points as input from  the user
        //   and calculates the distance between them.   */
        //
        // Console.Write("Enter Point 1 (X Y): ");
        // double[] point1 = Array.ConvertAll(
        //     Console.ReadLine()!.Split(' '), double.Parse);
        //
        // Console.Write("Enter Point 2 (X Y): ");
        // double[] point2 = Array.ConvertAll(Console.ReadLine()!.Split(' '), double.Parse);
        //
        // Point p01 = new Point(point1[0], point1[1]);
        // Point p02 = new Point(point2[0], point2[1]);
        //
        // double distance = Math.Sqrt(
        //     Math.Pow(p02.X - p01.X, 2) +
        //     Math.Pow(p02.Y - p01.Y, 2)
        // );
        //
        // Console.WriteLine($"Distance = {distance}");

        #endregion
    }
}