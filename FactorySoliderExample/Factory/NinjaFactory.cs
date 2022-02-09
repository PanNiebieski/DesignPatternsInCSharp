class NinjaFactory : ISoliderFactory
{
    public ISolider CreateSolider() => new Ninja();
}
