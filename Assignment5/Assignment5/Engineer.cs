namespace Assignment5;

public class Engineer : Person
{
    public string Field { get; set; }
    public int YearsOfExperience { get; set; }

    public new void Greet()
    {
        Console.WriteLine("I am an Engineer.");
    }

    public override void Display()
    {
        Console.WriteLine($"ID: {Id} \t Name: {Name} \t Age: {Age} \t Field: {Field}");
        Console.WriteLine($"Years of Experience: {YearsOfExperience}");
    }
}