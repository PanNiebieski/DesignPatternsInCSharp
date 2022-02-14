



OracleServer oracle = new OracleServer();
SQLServer sql = new SQLServer();

LogicAdapter adapterOracle = new LogicAdapter(oracle);
LogicAdapter adapterSQL = new LogicAdapter(sql);

Console.WriteLine(adapterOracle.IsWorking());
Console.WriteLine(adapterSQL.IsWorking());

public interface IServerCheck
{
    public int IsWorking();
}

public interface IServerBooleanCheck
{
    public bool? IsWorking();
}


public class IISServer : IServerBooleanCheck
{
    public bool? IsWorking()
    {
        return true;
    }
}

public class LogicAdapter : IServerBooleanCheck
{
    IServerCheck server;
    public LogicAdapter(IServerCheck server)
    {
        // musimy mieć referencje do obiektu
        // który będziemy adaptować
        this.server = server;
    }

    public bool? IsWorking()
    {
        int number = server.IsWorking();

        if (number == 1)
            return true;
        else if (number == 2)
            return false;

        return null;
    }

}


public class OracleServer : IServerCheck
{
    public int IsWorking()
    {
        return 2;
    }
}

public class SQLServer : IServerCheck
{
    public int IsWorking()
    {
        return 0;
    }
}


