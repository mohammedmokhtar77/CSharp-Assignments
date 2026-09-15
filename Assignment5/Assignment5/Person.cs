using System.Globalization;

namespace Assignment5;

public class Person
{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine("I am a Person.");
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {Id} \t Name: {Name} \t Age: {Age}");
        }
    
}