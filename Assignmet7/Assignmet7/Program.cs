namespace Assignmet7;

class Program
{
    static void Main()
    {
        #region Primary Constructor & Records

        Patient patient1 = new Patient(1, "Mohammed Mokhtar", "01111111111", "Good");
        
        Patient patient2 = new Patient(1, "Mohammed Mokhtar", "01111111111", "Good");

        Console.WriteLine("Before");
        Console.WriteLine($"Patient1 Hash Code : {patient1.GetHashCode()} " +
                          $":: Patient Hash Code : {patient2.GetHashCode()} " +
                          $":: Patient1 = Patient ? : {patient2.Equals(patient1)} ");
        
        patient2 = patient1;
        
        Console.WriteLine("After");
        Console.WriteLine($"Patient1 Hash Code : {patient1.GetHashCode()} " +
                          $":: Patient Hash Code : {patient2.GetHashCode()} " +
                          $":: Patient1 = Patient ? : {patient2.Equals(patient1)} ");

        #endregion
    }
}