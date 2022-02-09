




public class ILog
{
    public virtual void Info(string msg) { }
    public virtual void Error(string msg) { }
}

public class NullLog : ILog
{

}