// See https://aka.ms/new-console-template for more information
using System.Drawing;

var dic  = new Dictionary<string, string>()
        {
            {"Afghanistan","Kabul" },
            {"Brazil","Brasilia" },
            {"Bulgaria","Sofia" },
            {"Bolivia","Sucre" },
            {"Cyprus","Nicosia" },
            {"Denmark","Copenhagen" },
            {"England","London" },
            {"Finland","Kabul" },
            {"France","Paris" },
            {"Poland","Warsaw" },
        };

var fasade = new ConsoleTableFacade(dic, 5, '+');
fasade.Write();

public  class ConsoleTableFacade
{
    public char WriteSymbol { get; set; }
    public int NumberOfColums { get; set; }

    public Dictionary<string, string> Dictionary { get; set; }

    public int Intend { get; set; }

    public ConsoleTableFacade(Dictionary<string,string> dic, int intend, char writesymbol)
    {
        NumberOfColums = 2;
        WriteSymbol = writesymbol;
        Dictionary = dic;
        Intend = intend;
    }

    public void Write()
    {
        int biggestKeySize = 0;
        int biggestValueSize = 0;

        foreach (var item in Dictionary)
        {
            if (biggestKeySize < item.Key.Length)
                biggestKeySize = item.Key.Length;

            if (biggestValueSize < item.Value.Length)
                biggestValueSize = item.Value.Length;
        }

        biggestKeySize++;
        biggestValueSize++;
        foreach (var item in Dictionary)
        {
            Console.WriteLine();
            Console.Write(new string(' ', Intend));
            Console.WriteLine(new string(WriteSymbol, biggestKeySize + biggestValueSize + 5));
            Console.Write(new string(' ', Intend));
            Console.Write(WriteSymbol);
            Console.Write(" "+item.Key);
            Console.Write(new string(' ', biggestKeySize - item.Key.Length));
            Console.Write(WriteSymbol);
            Console.Write(" "+item.Value);
            Console.Write(new string(' ', biggestValueSize - item.Value.Length));
            Console.Write(WriteSymbol);
        }

        Console.WriteLine();
        Console.Write(new string(' ', Intend));
        Console.WriteLine(new string(WriteSymbol, biggestKeySize + biggestValueSize + 5));
        Console.WriteLine();
    }
}