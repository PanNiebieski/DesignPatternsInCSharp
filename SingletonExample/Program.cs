Console.WriteLine();
public static class Globals
{
    public static DatabaseInMemory
        Database = new DatabaseInMemory();
}


    public class DatabaseInMemory
{
    /// <summary>
    /// Please do not create more than one instance.
    /// </summary>
    public DatabaseInMemory() { }

};

