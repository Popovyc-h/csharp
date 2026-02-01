namespace Factory_Method;

internal class RoadLogistics : Logistics
{
    public override Transport CreateTransport()
    {
        return new Truck();
    }
}
