
// testing on a live database
var gf = new GameInYearFounder();
var years = new[] { 1991, 1992 };
var list = gf.GetNamesByYears(years);
Assert.That(list.Count == 1);


public class GameInYearFounder
{
    public List<string> TotalPopulation(IEnumerable<int> years)
    {
        var instance = SingletonGameDatabase.Instance;
        List<string> list = new List<string>();

        foreach (var year in years)
        {
            var game =
                instance.GetGameName(year);

            if (game != null)
                list.Add(game);
        }

        return list;
    }
}

public class ConfigurableGameInYearFounder
{
    private IDatabase database;

    public ConfigurableGameInYearFounder(IDatabase database)
    {
        this.database = database;
    }

    public List<string> GetNamesByYears(IEnumerable<int> years)
    {
        List<string> list = new List<string>();

        foreach (var year in years)
        {
            var game =
                database.GetGameName(year);

            if (game != null)
                list.Add(game);
        }

        return list;
    }
}


public class SingletonGameDatabase : IDatabase
{
    private Dictionary<string, int> games;
    private static int instanceCount;
    public static int Count => instanceCount;

    private SingletonGameDatabase()
    {
        Console.WriteLine("Initializing database");
        games = new Dictionary<string, int>()
        {
            {"Mortal Kombat",1 }
        };
    }

    public int GetGameYear(string name)
    {
        return games[name];
    }

    public string GetGameName(int year)
    {
        return games.
            FirstOrDefault(x => x.Value == year).Key;
    }

    private static Lazy<SingletonGameDatabase> instance =
    new Lazy<SingletonGameDatabase>(() =>
    {
        instanceCount++;
        return new SingletonGameDatabase();
    });

    public static IDatabase Instance => instance.Value;
}

public interface IDatabase
{
    int GetGameYear(string name);

    string GetGameName(int year);
}