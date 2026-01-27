namespace Attributes;

public class UserProfile
{
    [MyStringLength(20)]
    [MyRequired]
    public string FullName { get; set; }

    [MyRange(18, 100)]
    public int Age { get; set; }

    [MyPhone]
    public string PhoneNumber { get; set; }
}
