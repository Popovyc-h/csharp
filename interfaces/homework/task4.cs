namespace task4;

public interface IRemoteControl
{
    public void TurnOn();
    public void TurnOff();
    public void SetChannel(int channel);
}

public class TV : IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("The TV is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("The TV is off");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"Channel set to {channel}");
    }
}

public class Radio : IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("The radio is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("The radio is off");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"Radio tuned to channel {channel}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        var tv = new TV();
        var radio = new Radio();

        tv.TurnOn();
        tv.SetChannel(2);
        tv.TurnOff();
        Console.WriteLine();
        radio.TurnOn();
        radio.SetChannel(99);
        radio.TurnOff();
    }
}
