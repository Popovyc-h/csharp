namespace IntroductionToLINQ;

internal class Program
{
    static void Main(string[] args)
    {
        List<Firm> firms = new List<Firm>();
        var firm1 = new Firm("Food", new DateTime(2020, 12, 20), BusinessProfile.Marketing, "Oleg White", 230, "London");
        var firm2 = new Firm("White", new DateTime(2025, 1, 2), BusinessProfile.IT, "Victor Black", 303, "Chicago");

        var emp1 = new Employee("Mykhailo Shevchenko", "Project Manager", "+380971234567", "m.shevchenko@gmail.com", 4500m);
        var emp2 = new Employee("Lionel Kovalenko", "Software Developer", "+380501112233", "l.kovalenko@gmail.com", 3800m);
        var emp3 = new Employee("Andrii Bondarenko", "Manager", "+380931234987", "id.bondarenko@gmail.com", 5200m);
        var emp4 = new Employee("Bohdan Smachnyy", "Manager", "+380231638981", "b.smachnyy@gmail.com", 9200m);

        firms.AddRange(firm1, firm2);
        firm1.Employees.AddRange(emp1, emp2, emp3);
        firm2.Employees.Add(emp4);

        Console.WriteLine("=== All firms ===");
        firms.ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        var allEmployee = firms.SelectMany(e => e.Employees).ToList();

        Console.WriteLine("\n=== All employee ===");
        allEmployee.ForEach(f => Console.WriteLine($"{f.fullName} - {f.position} - {f.contactPhoneNumber} - {f.email} - {f.salary}"));

        var foodFirms = firms.Where(f => f.companyName.Contains("Food")).ToList();
        var itFirms = firms.Where(f => f.Profile == BusinessProfile.IT).ToList();
        var marketingOrItFirms = firms.Where(f => f.Profile == BusinessProfile.IT || f.Profile == BusinessProfile.Marketing).ToList();
        var firmsWithMoreThan100Employees = firms.Where(f => f.employeeCount > 100).ToList();
        var firmsWithEmployees100to300 = firms.Where(f => f.employeeCount >= 100 && f.employeeCount <= 300).ToList();
        var londonFirms = firms.Where(f => f.adress.Contains("London")).ToList();
        var directorsWithWhiteLastName = firms.Where(f => f.fullName.Contains("White")).ToList();
        var firmsOlderThanTwoYears = firms.Where(f => f.foundingDate < DateTime.Now.AddYears(-2));
        var firmsExactly123DaysOld = firms.Where(f => f.foundingDate < DateTime.Now.AddDays(-123));
        var firmsDirectorBlackNameWhiteCompany = firms.Where(f => f.fullName.Contains("Black") && f.companyName.Contains("White")).ToList();

        var employeesOfFirm = firm2.Employees.ToList();
        var employeesWithSalaryAboveThreshold = firm1.Employees.Where(e => e.salary > 4000).ToList();
        var managersInAllFirms = firms.SelectMany(f => f.Employees.Where(e => e.position.Contains("Manager"))).ToList();
        var employeesWithPhoneStarting23 = firms.SelectMany(f => f.Employees.Where(e => e.contactPhoneNumber.StartsWith("+38023"))).ToList();
        var employeesWithEmailStartingDi = firms.SelectMany(f => f.Employees.Where(e => e.email.StartsWith("id"))).ToList();
        var employeesNamedLionel = firm1.Employees.Where(e => e.fullName.Contains("Lionel")).ToList();

        Console.WriteLine("\nFirms only Food:");
        foodFirms.ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nOnly IT");
        itFirms.ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nMarketing or IT firms:");
        marketingOrItFirms.ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nNumber of employees more than 100:");
        firmsWithMoreThan100Employees.ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nNumber of employees in the range from 100 to 300");
        firmsWithEmployees100to300.ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nFirms in London:");
        londonFirms.ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nDirector's last name White");
        directorsWithWhiteLastName.ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nFirms older than 2 years:");
        firmsOlderThanTwoYears.ToList().ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nFirms exactly 123 days old:");
        firmsExactly123DaysOld.ToList().ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nFirms with director Black and company name containing White:");
        firmsDirectorBlackNameWhiteCompany.ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        //tasks with employees
        Console.WriteLine("\nEmployee firm2:");
        employeesOfFirm.ForEach(e => Console.WriteLine($"{e.fullName}, {e.position}, {e.salary}"));

        Console.WriteLine("\nEmployees with Salary > 4000:");
        employeesWithSalaryAboveThreshold.ForEach(e => Console.WriteLine($"{e.fullName}, {e.position}, {e.salary}"));

        Console.WriteLine("\nEmployees with position Manager:");
        managersInAllFirms.ForEach(e => Console.WriteLine($"{e.fullName}, {e.position}, {e.salary}"));

        Console.WriteLine("\nEmployees with phone starting with 23:");
        employeesWithPhoneStarting23.ForEach(e => Console.WriteLine($"{e.fullName}, {e.position}, {e.salary}"));

        Console.WriteLine("\nEmployees with email starting with 'di':");
        employeesWithEmailStartingDi.ForEach(e => Console.WriteLine($"{e.fullName}, {e.position}, {e.salary}"));

        Console.WriteLine("\nEmployees with name Lionel:");
        employeesNamedLionel.ForEach(e => Console.WriteLine($"{e.fullName}, {e.position}, {e.salary}"));
    }
}
