using System.Xml.Serialization;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        var config = new AppConfig("New mod", 11.2, true);
        string path = "config.xml";
        
        XmlSerializer ser = new XmlSerializer(typeof(AppConfig));

        using (FileStream write = new FileStream(path, FileMode.Create))
        {
            ser.Serialize(write, config);
        }
    }
}
