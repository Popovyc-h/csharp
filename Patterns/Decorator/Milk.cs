namespace Decorator;

public class Milk(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string Description => $"{_beverage.Description} + молоко";

    public override double Cost()
    {
        return _beverage.Cost() + 15;
    }
}
