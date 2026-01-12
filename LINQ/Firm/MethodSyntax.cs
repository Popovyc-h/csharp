using System.ComponentModel;

namespace IntroductionToLINQ;

internal class Program
{
    static void Main(string[] args)
    {
        List<Firm> firms = new List<Firm>();
        var firm1 = new Firm("Food", new DateTime(2020, 12, 20), BusinessProfile.Marketing, "Oleg White", 230, "London");
        var firm2 = new Firm("White", new DateTime(2025, 1, 2), BusinessProfile.IT, "Victor Black", 303, "Chicago");

        firms.Add(firm1);
        firms.Add(firm2);

        Console.WriteLine("All firms:");
        firms.ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

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
    }
}
