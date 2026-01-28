namespace Prototype;

public class Sheep
{
    public string Name;
    public int Age;

    public Sheep(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Sheep Clone()
    {
        return (Sheep)MemberwiseClone();
    }
}
