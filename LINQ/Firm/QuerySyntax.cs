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

        var foodFirms =
            from f in firms
            where f.companyName.Contains("Food")
            select f;

        var marketingFirms =
            from f in firms
            where f.Profile == BusinessProfile.Marketing
            select f;

        var marketingOrItFirms =
            from f in firms
            where f.Profile == BusinessProfile.Marketing
            || f.Profile == BusinessProfile.IT
            select f;

        var firmsWithMoreThan100Employees =
            from f in firms
            where f.employeeCount > 100
            select f;

        var firmsWithEmployees100to300 =
            from f in firms
            where f.employeeCount >= 100 && f.employeeCount <= 300
            select f;

        var londonFirms =
            from f in firms
            where f.adress.Contains("London")
            select f;

        var directorsWithWhiteLastName =
            from f in firms
            where f.fullName.Contains("White")
            select f;

        var firmsOlderThanTwoYears =
            from f in firms
            where f.foundingDate < DateTime.Now.AddYears(-2)
            select f;

        var firmsExactly123DaysOld =
            from f in firms
            where f.foundingDate < DateTime.Now.AddDays(-123)
            select f;

        var firmsDirectorBlackNameWhiteCompany =
            from f in firms
            where f.fullName.Contains("Black") &&  f.companyName.Contains("White")
            select f;

        Console.WriteLine("\nFirms only Food:");
        foodFirms.ToList()
            .ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nOnly Marketing");
        marketingFirms.ToList()
           .ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nMarketing or IT firms:");
        marketingOrItFirms.ToList()
            .ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nNumber of employees more than 100:");
        firmsWithMoreThan100Employees.ToList()
           .ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nNumber of employees in the range from 100 to 300");
        firmsWithEmployees100to300.ToList()
            .ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nFirms in London:");
        londonFirms.ToList()
            .ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nDirector's last name White");
        directorsWithWhiteLastName.ToList()
            .ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nFirms older than 2 years:");
        firmsOlderThanTwoYears.ToList()
            .ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nFirms exactly 123 days old:");
        firmsExactly123DaysOld.ToList()
            .ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));

        Console.WriteLine("\nFirms with director Black and company name containing White:");
        firmsDirectorBlackNameWhiteCompany.ToList()
            .ForEach(f => Console.WriteLine($"{f.companyName}, {f.foundingDate:dd.MM.yyyy}, {f.Profile}, {f.fullName}, {f.employeeCount}, {f.adress}"));
    }
}
