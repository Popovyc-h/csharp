namespace MusicalInstrument;

public class MusicalInstrument
{
    public string name;
    public string characteristics;

    public MusicalInstrument(string name, string characteristics)
    {
        this.name = name;
        this.characteristics = characteristics;
    }

    public virtual void Sound() { }
    public virtual void Show() { }
    public virtual void Desc() { }
    public virtual void History() { }
}

public class Violin : MusicalInstrument
{
    public Violin(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Вііііііін…");
    }

    public override void Show()
    {
        Console.WriteLine(name);
    }

    public override void Desc()
    {
        Console.WriteLine(characteristics);
    }

    public override void History()
    {
        Console.WriteLine("The violin originated in Italy in the 16th century and quickly became a primary instrument in orchestras.");
    }
}

public class Trombone : MusicalInstrument
{
    public Trombone(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Тууу–труууум…");
    }

    public override void Show()
    {
        Console.WriteLine(name);
    }

    public override void Desc()
    {
        Console.WriteLine(characteristics);
    }

    public override void History()
    {
        Console.WriteLine("The trombone appeared in the 15th century and was used in church and military music.");
    }
}

public class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Тінь-ті-лі-лін…");
    }

    public override void Show()
    {
        Console.WriteLine(name);
    }

    public override void Desc()
    {
        Console.WriteLine(characteristics);
    }

    public override void History()
    {
        Console.WriteLine("The ukulele originated in Hawaii in the 19th century, adapted from Portuguese string instruments.");
    }
}

public class Cello : MusicalInstrument
{
    public Cello(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Моооооо…");
    }

    public override void Show()
    {
        Console.WriteLine(name);
    }

    public override void Desc()
    {
        Console.WriteLine(characteristics);
    }

    public override void History()
    {
        Console.WriteLine("The cello was created in Italy in the 16th century and became the foundation of the string section in orchestras.");
    }
}

internal class task3
{
    static void Main(string[] args)
    {
        var violin = new Violin("Stradivarius Violin", "4 strings, wooden body, classical instrument");
        var trombone = new Trombone("Golden Trombone", "brass instrument, slide mechanism, orchestral");
        var ukulele = new Ukulele("Hawaii Ukulele", "4 strings, small body, bright tone");
        var cello = new Cello("Concert Cello", "4 strings, large wooden body, deep warm sound");

        violin.Show();
        violin.Sound();
        violin.Desc();
        violin.History();
        Console.WriteLine();
        trombone.Show();
        trombone.Sound();
        trombone.Desc();
        trombone.History();
        Console.WriteLine();
        ukulele.Show();
        ukulele.Sound();
        ukulele.Desc();
        ukulele.History();
        Console.WriteLine();
        cello.Show();
        cello.Sound();
        cello.Desc();
        cello.History();
    }
}
