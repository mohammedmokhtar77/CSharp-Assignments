namespace Assignment5;

public class Doctor : Person
{
    public string Specialty { get; set; }

    public new void Greet()
    {
        Console.WriteLine("I am a Doctor.");
    }

    public override void Display()
    {
        Console.WriteLine($"ID: {Id} \t Name: {Name} \t Age: {Age} \t Specialty = {Specialty}");
        // I can make base.Display() then Speciality
    }
}