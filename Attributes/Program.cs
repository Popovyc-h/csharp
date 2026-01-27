namespace Attributes;

class Program
{
    static void Main()
    {
        var user = new UserProfile { FullName = "", Age = 150, PhoneNumber = "invalid" };

        Console.WriteLine("--- Початок валідації ---");
        bool result = SimpleValidator.Validate(user);

        if (result) Console.WriteLine("Валідація успішна!");
        else Console.WriteLine("Валідація провалена.");
    }
}
