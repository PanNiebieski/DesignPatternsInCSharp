public class DatabaseInMemory
{
    private DatabaseInMemory() {  }

    public static DatabaseInMemory Instance { get; } 
        = new DatabaseInMemory();
}
