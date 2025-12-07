namespace Device;

public class Device
{
    public string name;
    public string characteristics;

    public Device(string name, string characteristics)
    {
        this.name = name;
        this.characteristics = characteristics;
    }

    public virtual void Sound() { }
    public virtual void Show() { }
    public virtual void Desc() { }
}

public class Kettle : Device
{
    public Kettle(string name, string characteristics) : base(name, characteristics)
    { }

    public override void Sound()
    {
        Console.WriteLine("Шшшш... кипіння");
    }

    public override void Show()
    {
        Console.WriteLine(name);
    }

    public override void Desc()
    {
        Console.WriteLine(characteristics);
    }
}

public class Microwave : Device
{
    public Microwave(string name, string characteristics) : base(name, characteristics)
    { }

    public override void Sound()
    {
        Console.WriteLine("Біп-біп-біп");
    }

    public override void Show()
    {
        Console.WriteLine(name);
    }

    public override void Desc()
    {
        Console.WriteLine(characteristics);
    }
}

public class Car : Device
{
    public Car(string name, string characteristics) : base(name, characteristics)
    { }

    public override void Sound()
    {
        Console.WriteLine("Врум-врум");
    }

    public override void Show()
    {
        Console.WriteLine(name);
    }

    public override void Desc()
    {
        Console.WriteLine(characteristics);
    }
}

public class Steamer : Device
{
    public Steamer(string name, string characteristics) : base(name, characteristics)
    { }

    public override void Sound()
    {
        Console.WriteLine("Тууууууууу");
    }

    public override void Show()
    {
        Console.WriteLine(name);
    }

    public override void Desc()
    {
        Console.WriteLine(characteristics);
    }
}

internal class task2
{
    static void Main(string[] args)
    {
        var kettle = new Kettle("Electric Kettle", "1.7L, 2200W, stainless steel");
        var microwave = new Microwave("SmartWave 900", "900W, 20L, grill mode");
        var car = new Car("TurboCar X", "150 HP, automatic, petrol");
        var steamer = new Steamer("SeaMaster", "4000 tons, diesel engine, cargo ship");

        kettle.Show();
        kettle.Sound();
        kettle.Desc();
        Console.WriteLine();
        microwave.Show();
        microwave.Sound();
        microwave.Desc();
        Console.WriteLine();
        car.Show();
        car.Sound();
        car.Desc();
        Console.WriteLine();
        steamer.Show();
        steamer.Sound();
        steamer.Desc();
    }
}
