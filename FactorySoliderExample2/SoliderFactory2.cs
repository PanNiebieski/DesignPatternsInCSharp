


static class SoliderFactory2
{
    public static ISolider Create(Type type)
    {
        ISolider sol = null;
        switch (type)
        {
            case Type.Ninja:
                sol = new Ninja();
                break;
            case Type.Samurai:
                sol = new Samurai();
                break;
        }

        return sol;
    }
}
