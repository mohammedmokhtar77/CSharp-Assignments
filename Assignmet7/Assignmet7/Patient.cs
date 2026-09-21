namespace Assignmet7;

public class Patient(int Id , string FullName , string PhoneNumber , string MedicalHistory)
{
    public override string ToString()
    {
        return $"ID : {Id} :: Full Name : {FullName} " +
               $":: Phone Number: {PhoneNumber} :: Medical History : {MedicalHistory}";
    }
}