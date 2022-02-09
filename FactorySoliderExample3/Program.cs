
Run(1, () => new Ninja());
Run(2, () => new Samurai());


static void Run(int number, Func<ISolider> factoryFunc)
{
    var sol = factoryFunc();

    Console.WriteLine($"Solider nr : {number} " +
        $"\n\t Kosztuje : {sol.Price()}" +
        $"\n\t Walczy : {sol.Fight()}");
}
