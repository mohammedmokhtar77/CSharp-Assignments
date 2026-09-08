namespace Assignment3;

class Program
{
    static void Main(string[] args)
    {
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
        
        

    }
}