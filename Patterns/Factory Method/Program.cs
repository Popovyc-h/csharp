namespace Factory_Method;

internal class Program
{
    static void Main(string[] args)
    {
        Logistics logistics = new SeaLogistics();
        Transport transport = logistics.CreateTransport();
        transport.Deliver();
    }
}
