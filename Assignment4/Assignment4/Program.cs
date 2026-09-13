namespace Assignment4;

class Program
{
    static void Main(string[] args)
    {
        Employee[] Employees = new Employee[3];
        Employees[0] = new Employee(
            1,
            "Mokhtar",
            SecurityLevel.DBA,
            30000m,
            new HiringDate(18, 4, 1981),
            Gender.Male
        );

        Employees[1] = new Employee(
            2,
            "Ali",
            SecurityLevel.Guest,
            12000m,
            new HiringDate(29, 7, 2003),
            Gender.Female
        );

        Employees[2] = new Employee(
            3,
            "Mohammed",
            SecurityLevel.SecurityOfficer,
            40000m,
            new HiringDate(10, 1, 2006),
            Gender.Male
        );

        foreach (Employee employee in Employees)
        {
            Console.WriteLine(employee);
        }

    }
}