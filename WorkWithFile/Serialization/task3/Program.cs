namespace ConsoleApp1;

using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

internal class Program
{
    static void Main(string[] args)
    {
        List<Contact> contacts = new List<Contact>();
        var jsonPath = "contacts.json";
        var xmlPath = "contacts.xml";

        var firstContact = new Contact("Oleg", "067-123-4567");
        var secondContact = new Contact("Vasily", "098-555-2211");
        var thirdContact = new Contact("Igor", "095-777-8899");

        contacts.AddRange(firstContact, secondContact, thirdContact);

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        var json = JsonSerializer.Serialize(contacts, options);
        File.WriteAllText(jsonPath, json);
        Console.WriteLine("JSON файл створено");

        var jsonFromFile = File.ReadAllText(jsonPath);
        var jsonRead = JsonSerializer.Deserialize<List<Contact>>(jsonFromFile);
        Console.WriteLine("\n=== ДЕСЕРІАЛІЗАЦІЯ JSON ===");

        XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));

        using (StreamWriter writer = new StreamWriter(xmlPath))
        {
            serializer.Serialize(writer, jsonRead);
        }
        Console.WriteLine("XML файл створено!");
    }
}
