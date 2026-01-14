namespace IntroductionToLINQ;

internal class Employee
{
    public string fullName;
    public string position;
    public string contactPhoneNumber;
    public string email;
    public decimal salary;

    public Employee(string fullName, string position, string contactPhoneNumber, string email, decimal salary)
    {
        this.fullName = fullName;
        this.position = position;
        this.contactPhoneNumber = contactPhoneNumber;
        this.email = email;
        this.salary = salary;
    }
}
