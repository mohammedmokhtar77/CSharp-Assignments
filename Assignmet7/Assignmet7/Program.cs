namespace Assignmet7;

class Program
{
    static void Main()
    {
        #region Primary Constructor & Records

        #region Primary Constructor
        //
        // Patient patient1 = new Patient(1, "Mohammed Mokhtar", "01111111111", "Good");
        //
        // Patient patient2 = new Patient(1, "Mohammed Mokhtar", "01111111111", "Good");
        //
        // Console.WriteLine("Before");
        // Console.WriteLine($"Patient1 Hash Code : {patient1.GetHashCode()} " +
        //                   $":: Patient Hash Code : {patient2.GetHashCode()} " +
        //                   $":: Patient1 = Patient ? : {patient2.Equals(patient1)} ");
        //
        // patient2 = patient1;
        //
        // Console.WriteLine("After");
        // Console.WriteLine($"Patient1 Hash Code : {patient1.GetHashCode()} " +
        //                   $":: Patient Hash Code : {patient2.GetHashCode()} " +
        //                   $":: Patient1 = Patient ? : {patient2.Equals(patient1)} ");

        #endregion

        #region Records
        //
        // PatientDto patientDto1 = new PatientDto(1, "Mohammed Mokhtar", "01111111111");
        //
        // PatientDto patientDto2 = new PatientDto(1, "Mohammed Mokhtar", "01111111111");
        //
        // Console.WriteLine("Before");
        // Console.WriteLine($"Patient1 Hash Code : {patientDto1.GetHashCode()} " +
        //                   $":: Patient Hash Code : {patientDto2.GetHashCode()} " +
        //                   $":: Patient1 = Patient ? : {patientDto2.Equals(patientDto1)} ");
        //
        // patientDto2 = patientDto1;
        //
        // Console.WriteLine("After");
        // Console.WriteLine($"Patient1 Hash Code : {patientDto1.GetHashCode()} " +
        //                   $":: Patient Hash Code : {patientDto2.GetHashCode()} " +
        //                   $":: Patient1 = Patient ? : {patientDto2.Equals(patientDto1)} ");

        #endregion
        
        // Class compares objects by reference by default,
        // while record compares objects by value (content) , override ToString , GetHashCode , Equals.
        
        #endregion
    }
}