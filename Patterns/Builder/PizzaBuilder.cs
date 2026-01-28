namespace Builder;

public class PizzaBuilder
{
    private Pizza _pizza = new Pizza();

    public PizzaBuilder SetDough(string dough)
    {
        _pizza.Dough = dough;
        return this;
    }

    public PizzaBuilder SetSauce(string sauce)
    {
        _pizza.Sauce = sauce;
        return this;
    }

    public PizzaBuilder AddCheese()
    {
        _pizza.HasCheese = true;
        return this;
    }

    public PizzaBuilder AddPepperoni()
    {
        _pizza.HasPepperoni = true;
        return this;
    }

    public PizzaBuilder AddMushrooms()
    {
        _pizza.HasMushrooms = true;
        return this;
    }

    public Pizza Build()
    {
        return _pizza;
    }
}
