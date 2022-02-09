public class CachedData
{
    private CachedData()
    {
        Console.WriteLine("Initializing database");
    }

    private static Lazy<CachedData> instance =
    new Lazy<CachedData>(() => new CachedData());

    public static CachedData Instance => instance.Value;
}