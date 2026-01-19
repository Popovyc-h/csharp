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
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty", nameof(name));

            name = value;
        }
    }

    public int Level
    {
        get => level;
        set
        {
            if (level < 0)
                throw new ArgumentOutOfRangeException("level cannot be negative", nameof(level));

            level = value;
        }
    }

    public int Health
    {
        get => health;
        set
        {
            if (health <= 0 && health > 100)
                throw new ArgumentException("health must be between 1 and 100", nameof(health));

            health = value;
        }
    }
}
