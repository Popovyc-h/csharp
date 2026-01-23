using System.Text.Json;

namespace WorkWithFile;

internal class Program
{
    static void Main(string[] args)
    {
        List<Contact> contacts = new List<Contact>();
        var path = "contacts.json";

        var firstContact = new Contact("Oleg", "067-123-4567");
        var secondContact = new Contact("Vasily", "098-555-2211");
        var thirdContact = new Contact("Igor", "095-777-8899");

        contacts.AddRange(firstContact, secondContact, thirdContact);

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        Console.WriteLine("=== СЕРІАЛІЗАЦІЯ ===");
        var jsonString = JsonSerializer.Serialize(contacts, options);

        File.WriteAllText(path, jsonString);

        Console.WriteLine("\n=== ДЕСЕРІАЛІЗАЦІЯ ===");
        string jsonRead = File.ReadAllText(path);
        List<Contact> loaded = JsonSerializer.Deserialize<List<Contact>>(jsonRead);

        foreach (var contact in loaded)
            contact.Print();
    }
}
