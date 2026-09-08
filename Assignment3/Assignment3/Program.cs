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
        
    }
}