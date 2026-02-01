namespace Factory_Method;

internal class Ship : Transport
{
    public override void Deliver()
    {
        Console.WriteLine("Доставка вантажу морем");
    }
}
