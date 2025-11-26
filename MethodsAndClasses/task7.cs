Tank tank1 = new Tank(11.1);
Tank tank2 = new Tank(20, "iron");
Tank tank3 = new Tank(100.0, "iron", 50.0);

try
{
    tank3.fill(5);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Tank
{
    private double volume;
    private string material;
    private double currentLevel = 0;

    public Tank(double volume)
    {
        this.volume = volume;
        this.material = "unknown";
        this.currentLevel = 0;
    }

    public Tank(double volume, string material)
    {
        this.volume = volume;
        this.material = material;
        this.currentLevel = 0;
    }

    public Tank(double volume, string material, double currentLevel)
    {
        this.volume = volume;
        this.material = material;
        this.currentLevel = currentLevel;
    }

    public void fill(double amount)
    {
        if (amount <= 0)
            throw new Exception("Amount cannot be negative");

        if (currentLevel + amount > volume)
            throw new Exception("Tank overflow occurred");
        
        currentLevel += amount;
        Console.WriteLine($"Added {amount} L. Current level: {currentLevel}/{volume} L");
    }

    public void empty()
    {
        currentLevel = 0;
        Console.WriteLine("Tank successfully emptied");
    }
}
