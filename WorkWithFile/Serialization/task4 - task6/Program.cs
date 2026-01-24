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
        Console.WriteLine("Contact added");
    }

    public static void UpdatePhone(string name, string newPhone)
    {
        var path = "contacts.json";
        List<Contact> contacts = new List<Contact>();

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        if (File.Exists(path))
        {
            var read = File.ReadAllText(path);
            var deserialize = JsonSerializer.Deserialize<List<Contact>>(read);

            if (deserialize != null)
                contacts = deserialize;

            var findName = contacts.FirstOrDefault(c => c.name == name);

            if (findName != null)
            {
                findName.number = newPhone;
                
                var serializer = JsonSerializer.Serialize(contacts, options);
                File.WriteAllText(path, serializer);
                Console.WriteLine("The number change was successful");
            }
            else
                Console.WriteLine("Contact not found");
        }
    }

    public static void RemoveContact(string name)
    {
        var path = "contacts.json";
        List<Contact> contacts = new List<Contact>();

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        if (File.Exists(path))
        {
            var read = File.ReadAllText(path);

            var deserialize = JsonSerializer.Deserialize<List<Contact>>(read);

            if (deserialize != null)
                contacts = deserialize;

            var findName = contacts.FirstOrDefault(c => c.name == name);

            if (findName != null)
            {
                contacts.Remove(findName);
                
                var serializer = JsonSerializer.Serialize(contacts, options);
                File.WriteAllText(path, serializer);
                Console.WriteLine("Contact deleted");
            }
            else
                Console.WriteLine("Contact not found");
        }
    }

    static void Main(string[] args)
    {
        var firstContact = new Contact("Bobic", "010122");

        //AddContact(firstContact);

        UpdatePhone("Bublic", "0283");

        RemoveContact("Bobic");
    }
}
