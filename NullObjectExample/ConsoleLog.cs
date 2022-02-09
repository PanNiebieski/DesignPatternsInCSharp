class ConsoleLog : ILog
{
    public void Info(string msg)
    {
        Console.WriteLine(msg);
    }
    public void Error(string msg)
    {
        Console.WriteLine("ERROR:" + msg);
    }
}
