class SamuraiFactory : ISoliderFactory
{
    public ISolider CreateSolider() => new Samurai();
}
