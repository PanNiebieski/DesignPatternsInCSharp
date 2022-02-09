
AuthorOfThisBlog author1 = new AuthorOfThisBlog();
AuthorOfThisBlog author2 = new AuthorOfThisBlog();
AuthorOfThisBlog author3 = new AuthorOfThisBlog();

author1.Name = "Daniel";
author2.Age = 33;

Console.WriteLine(author3.Name);
Console.WriteLine(author3.Age);

public class AuthorOfThisBlog
{
    private static string name = "Cezary";
    private static int age = 23;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }
}


public class DatabaseInMemory
{
    private static DatabaseInMemory _m = new DatabaseInMemory();

    private static bool _alreadyexist = false;

    public DatabaseInMemory()
    {
        if (!_alreadyexist)
        {
            Data = new string[] { "Ala", "Tomek" };
            _alreadyexist = true;
        }
        else
        {
            this.Data = _m.Data;
        }

    }

    public string[] Data { get; }
}