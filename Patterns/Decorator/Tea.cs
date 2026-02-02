namespace Decorator;

public class Tea : Beverage
{
    public Tea()
    {
        Description = "Чай";
    }

    // TODO: Реалізувати Cost() -> 40
    public override double Cost()
    {
        return 40;
    }
}
