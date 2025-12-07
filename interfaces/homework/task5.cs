namespace task5;

public interface IValidator
{
    public bool Validate();
}

public class PasswordValidator : IValidator
{
    private string password;

    public PasswordValidator(string password)
    {
        this.password = password;
    }

    public bool Validate()
    {
        if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            return false;

        return true;
    }
}

public class EmailValidator : IValidator
{
    public string email;

    public EmailValidator(string email)
    {
        this.email = email;
    }

    public bool Validate()
    {
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            return false;

        return true;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        var password_1 = new PasswordValidator("21129481");
        var email_1 = new EmailValidator("asjcei@gmail.com");

        var password_2 = new PasswordValidator("1 1 2");
        var email_2 = new EmailValidator("asjcei.com");

        Console.WriteLine(password_1.Validate());
        Console.WriteLine(email_1.Validate());

        Console.WriteLine(password_2.Validate());
        Console.WriteLine(email_2.Validate());
    }
}
