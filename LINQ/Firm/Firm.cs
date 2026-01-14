namespace IntroductionToLINQ;

public enum BusinessProfile
{
    Marketing,
    IT
};

internal class Firm
{
    public List<Employee> Employees = new List<Employee>();
    public string companyName;
    public DateTime foundingDate;
    public BusinessProfile Profile;
    public string fullName;
    public int employeeCount;
    public string adress;

    public Firm(string companyName, DateTime foundingDate, BusinessProfile Profile, string fullName, int employeeCount, string adress)
    {
        this.companyName = companyName;
        this.foundingDate = foundingDate;
        this.Profile = Profile;
        this.fullName = fullName;
        this.employeeCount = employeeCount;
        this.adress = adress;
    }
}
