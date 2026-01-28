namespace Builder;

public class Pizza
{
    public string Dough;
    public string Sauce;
    public bool HasCheese;
    public bool HasPepperoni;
    public bool HasMushrooms;

    public void Print()
    {
        Console.WriteLine($"{Dough} {Sauce} {HasCheese} {HasPepperoni} {HasMushrooms}");
    }
}
