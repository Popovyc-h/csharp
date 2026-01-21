namespace ConsoleApp1;

public class AppConfig
{
    public string AppName { get; set; }
    public double Version { get; set; }
    public bool IsPro { get; set; }

    public AppConfig()
    {

    }
    public AppConfig(string AppName, double Version, bool IsPro)
    {
        this.AppName = AppName;
        this.Version = Version;
        this.IsPro = IsPro;
    }
}
