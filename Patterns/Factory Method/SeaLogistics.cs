namespace Factory_Method;

internal class SeaLogistics : Logistics
{
    public override Transport CreateTransport()
    {
        return new Ship();
    }
}
