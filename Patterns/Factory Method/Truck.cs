namespace Factory_Method;

internal class Truck : Transport
{
    public override void Deliver()
    {
        Console.WriteLine("Доставка вантажу дорогою");
    }
}
