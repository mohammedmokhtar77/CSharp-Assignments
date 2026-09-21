namespace Assignmet7;

public class Patient()
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string? MedicalHistory { get; set; }
    public override string ToString()
    {
        return $"ID : {Id} :: Full Name : {FullName} " +
               $":: Phone Number: {PhoneNumber} :: Medical History : {MedicalHistory}";
    }
}