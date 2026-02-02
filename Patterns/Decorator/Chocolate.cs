namespace Decorator;

public class Chocolate(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string Description => $"{_beverage.Description} + шоколад";

    public override double Cost()
    {
        return _beverage.Cost() + 20;
    }
}
