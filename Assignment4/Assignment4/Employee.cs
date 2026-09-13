namespace Assignment4;

public class Employee
{
    // Employee ID
    public int ID { get; set; }
    
    //Employee Name
    public string Name { get; set; }
    
    // Employee Security Level
    public SecurityLevel SecurityLevel { get; set; }

    // Employee Salary
    public decimal Salary { get; set; }

    // Employee Hiring Date
    public HiringDate HireDate { get; set; }

    // Employee Gender
    public Gender Gender { get; set; }
    
    // ParameterLess Constructor & Chain
    public Employee() : this(0, "Unknown", SecurityLevel.Guest, 
                        0m, new HiringDate(), Gender.Male) {}

    // Parameterized Constructor
    public Employee(int id, string name, SecurityLevel securityLevel,
                    decimal salary, HiringDate hireDate, Gender gender)
    {
        ID = id;
        Name = name;
        SecurityLevel = securityLevel;
        Salary = salary;
        HireDate = hireDate;
        Gender = gender;
    }
    public override string ToString()
    { 
        return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, " +
               $"Salary: {Salary:C}, Hire Date: {HireDate}, Gender: {Gender}"; ;
    }
}