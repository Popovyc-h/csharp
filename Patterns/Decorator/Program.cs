namespace Decorator;

class Program
{
    static void Main()
    {
        Beverage espresso = new Espresso();
        
        Console.WriteLine(espresso.Description);
        Console.WriteLine(espresso.Cost());

        // TODO: Створити напій: Еспресо + Молоко + Цукор
        // Вивести на екран Опис та Загальну суму

        espresso = new Milk(espresso);
        espresso = new Sugar(espresso);
        
        Console.WriteLine();
        Console.WriteLine(espresso.Description);
        Console.WriteLine(espresso.Cost());
    }
}
