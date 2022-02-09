// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



public class Shopping
{
    public string When;
    public string What;
}


public abstract class ShoppingBuilder
{
    protected Shopping shopping = new Shopping();
    public Shopping Build()
    {
        return shopping;
    }
}

public class ShoppingTimeBuilder : ShoppingBuilder
{
    public ShoppingTimeBuilder When(string when)
    {
        shopping.When = when;
        return this;
    }
}

public class ShoppingWhatBuilder : ShoppingTimeBuilder
{
    public ShoppingWhatBuilder What(string what)
    {
        shopping.What = what;
        return this;
    }
}