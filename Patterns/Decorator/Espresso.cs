namespace Decorator;

// 2. Конкретні компоненти (Напої)
public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Еспресо";
    }

    // TODO: Реалізувати Cost() -> 60

    public override double Cost()
    {
        return 60;
    }
}
