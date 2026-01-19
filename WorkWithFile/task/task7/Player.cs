namespace ConsoleApp1;

internal class Player
{
    private string name;
    private int level;
    private int health;

    public Player(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty", nameof(Name));

            name = value;
        }
    }

    public int Level
    {
        get => level;
        set
        {
            if (level < 0)
                throw new ArgumentOutOfRangeException("level cannot be negative", nameof(Level));

            level = value;
        }
    }

    public int Health
    {
        get => health;
        set
        {
            if (value <= 0 || value > 100)
                throw new ArgumentException("health must be between 1 and 100", nameof(Health));

            health = value;
        }
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Level: {Level}, Health: {Health}");
    }
}
