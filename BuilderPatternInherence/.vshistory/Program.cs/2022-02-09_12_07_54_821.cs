// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



public class Shopping
{
    public string Name;
    public string Position;
}


public abstract class PersonBuilder
{
    protected Shopping person = new Shopping();
    public Shopping Build()
    {
        return person;
    }
}

public class PersonInfoBuilder : PersonBuilder
{
    public PersonInfoBuilder Called(string name)
    {
        person.Name = name;
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