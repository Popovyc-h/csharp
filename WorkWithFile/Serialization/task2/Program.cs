internal class Program
{
    static void Main(string[] args)
    {
        List<Contact> contacts = new List<Contact>();
        var path = "contacts.json";

        var firstContact = new Contact("Олег", "067-123-4567");
        var secondContact = new Contact("Марія", "098-555-2211");
        var thirdContact = new Contact("Ігор", "095-777-8899");

        contacts.AddRange(firstContact, secondContact, thirdContact);

        Console.WriteLine("=== СЕРІАЛІЗАЦІЯ ===");
        var jsonString = JsonSerializer.Serialize(contacts);

        File.WriteAllText(path, jsonString);

        Console.WriteLine("\n=== ДЕСЕРІАЛІЗАЦІЯ ===");
        string jsonRead = File.ReadAllText(path);
        List<Contact> loaded = JsonSerializer.Deserialize<List<Contact>>(jsonRead);

        foreach (var contact in contacts)
            contact.Print();
    }
}
