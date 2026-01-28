namespace Builder;

internal class Program
{
    static void Main(string[] args)
    {
        Pizza myPizza = new PizzaBuilder().SetDough("thin").SetSauce("tomato").AddCheese().Build();

        myPizza.Print();
    }
}
