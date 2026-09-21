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

        // Patient patient = new Patient()
        //     { Id = 1, FullName = "Mohammed Mokhtar", PhoneNumber = "01111111111", MedicalHistory = "Good" };
        //  PatientDto patientDto = PatientMapper.MapFromModelToDto(patient);
        //  Console.WriteLine(patientDto);

        #endregion

        #region Singleton

        // AppLogger logger1 = AppLogger.GetLogger();
        // AppLogger logger2 = AppLogger.GetLogger();
        //
        // Console.WriteLine($"Log1 Hash Code : {logger1.GetHashCode()} :: Log2 Hash Code : {logger2.GetHashCode()} ");
        // Console.WriteLine(logger1 == logger2); // True
        // Singleton ensures only one instance of AppLogger exists and provides global access to that instance.
        #endregion

        #region var & dynamic

        Patient p = new Patient(){Id = 1,FullName = "Mohammed",PhoneNumber = "01111111111",MedicalHistory = "None"};

        var patient2 = new Patient(){Id = 2,FullName = "Ahmed",PhoneNumber = "01222222222",MedicalHistory = "Diabetes"};

        dynamic patient3 = new Patient(){Id = 3,FullName = "Omar",PhoneNumber = "01555555555",MedicalHistory = "None"};
        Console.WriteLine(patient3);

        // var is resolved at compile time, while dynamic is resolved at run time.

        #endregion
    }
}