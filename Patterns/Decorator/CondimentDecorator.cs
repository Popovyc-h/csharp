namespace Decorator;

// 3. Базовий декоратор
public abstract class CondimentDecorator(Beverage beverage) : Beverage
{
    protected Beverage _beverage = beverage;

    // Ми змушуємо декоратори перевизначити опис, щоб додати назву добавки
    public abstract override string Description { get; }
}
