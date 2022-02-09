
Run(1, new NinjaFactory());
Run(2, new SamuraiFactory());


static void Run(int number, ISoliderFactory factory)
{
    var sol = factory.CreateSolider();

    Console.WriteLine($"Solider nr : {number} " +
        $"\n\t Kosztuje : {sol.Price()}" +
        $"\n\t Walczy : {sol.Fight()}");
}
