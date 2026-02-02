namespace Decorator;

public class Sugar(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string Description => $"{_beverage.Description} + цукор";

    public override double Cost()
    {
        return _beverage.Cost() + 5;
    }
}
