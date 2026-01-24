using System.Text.Json;

namespace WorkWithFile;

internal class Program
{
    public static void AddContact(Contact newContact)
    {
        var path = "contacts.json";
        List<Contact> contacts = new List<Contact>();

        if (File.Exists(path))
        {
            var read = File.ReadAllText(path);
            var deserialize = JsonSerializer.Deserialize<List<Contact>>(read);
            
            if (deserialize != null)
                contacts = deserialize;
        }
        
        contacts.Add(newContact);

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        var serializer = JsonSerializer.Serialize(contacts, options);

        File.WriteAllText(path, serializer);
    }

    static void Main(string[] args)
    {
        var firstContact = new Contact("Bobic", "2091");

        AddContact(firstContact);
    }
}
