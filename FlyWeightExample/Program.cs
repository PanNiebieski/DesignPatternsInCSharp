
Console.WriteLine();

public class Contract
{
    public string CustomerFullName { get;  }

    public string TypeDeal { get; }

    public Contract(string fullname, string typedeal)
    {
        CustomerFullName = fullname;
        TypeDeal = typedeal;
    }
}


public class Contract2
{
    private static List<string> _cachedNames = new List<string>();
    private int[] flyweightsNames;

    private static List<string> _cachedTypeDeal = new List<string>();
    private int[] flyweightsTypeDeal;

    public Contract2(string fullname, string typedeal)
    {
        int getOrAdd(string s, List<string> cache)
        {
            int idx = cache.IndexOf(s);
            if (idx != -1) return idx;
            else
            {
                cache.Add(s);
                return cache.Count - 1;
            }
        }

        flyweightsNames = fullname.Split(' ')
            .Select(s => getOrAdd(s, _cachedNames)).ToArray();

        flyweightsTypeDeal = typedeal.Split(' ')
            .Select(s => getOrAdd(s, _cachedTypeDeal)).ToArray();
    }

    public string CustomerFullName => string.Join(" ",
        flyweightsNames.Select(i =>_cachedNames[i]));

    public string TypeDeal => string.Join(" ",
    flyweightsTypeDeal.Select(i => _cachedTypeDeal[i]));
}

