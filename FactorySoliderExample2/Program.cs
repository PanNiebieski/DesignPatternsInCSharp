
Run(1, Type.Samurai);
Run(2, Type.Ninja);


static void Run(int number, Type type)
{
    var sol = SoliderFactory2.Create(type);

    Console.WriteLine($"Solider nr : {number} " +
        $"\n\t Kosztuje : {sol.Price()}" +
        $"\n\t Walczy : {sol.Fight()}");
}
