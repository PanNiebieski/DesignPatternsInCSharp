public sealed class NullLog : ILog
{
    public void Info(string msg) { }
    public void Error(string msg) { }
}