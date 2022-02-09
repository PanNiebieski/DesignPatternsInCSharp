// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



public class Shopping
{
    public string When;
    public string What;
}


public abstract class ShoppingBuilder
{
    protected Shopping person = new Shopping();
    public Shopping Build()
    {
        return person;
    }
}

public class ShoppingTimeBuilder : ShoppingBuilder
{
    public PersonInfoBuilder Called(string name)
    {
        person.When = name;
        return this;
    }
}

public class PersonJobBuilder : PersonInfoBuilder
{
    public PersonJobBuilder WorksAsA(string position)
    {
        person.Position = position;
        return this;
    }
}