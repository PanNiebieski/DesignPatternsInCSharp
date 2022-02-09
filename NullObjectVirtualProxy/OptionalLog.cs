public class OptionalLog : ILog
{
    private ILog impl;
    private static ILog NoLogging = null;

    public OptionalLog(ILog impl)
    {
        this.impl = impl;
    }
    public void Info(string msg)
    {
        impl?.Info(msg);
    }

    public void Error(string msg)
    {
        impl?.Error(msg);
    }
}
