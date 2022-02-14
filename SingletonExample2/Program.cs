using System;

Console.WriteLine();

public class DatabaseInMemory
{
    private static int instanceCount = 0;

    DatabaseInMemory()
    {
        if (++instanceCount > 1)
            throw new InvalidOperationException
                (@"Cannot make >1 database!");
    }
}