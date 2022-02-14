Console.WriteLine();


public class OperationStatusFactory
{
    private static OperationStatus main =
    new OperationStatus(null, new Info("TEST", ".NET", 0));
    private static OperationStatus java =
    new OperationStatus(null, new Info("WEB API", "JAVA", 0));

    public static OperationStatus NewRedDotNetStatus(string name, int
    time) =>
    NewStatus(main, name, time, true);

    public static OperationStatus NewGreenJavaStatus(string name, int
    time) =>
    NewStatus(java, name, time, false);

    private static OperationStatus NewStatus(OperationStatus proto, string name,
    int time, bool isred)
    {
        var copy = proto.DeepCopy();
        copy.NameOfOperation = name;
        copy.Information.Time = time;
        copy.IsRed = isred;
        return copy;
    }
}

public class OperationStatus : IDeepCopyable<OperationStatus>
{
    public OperationStatus(string nameOfOperation, Info info)
    {
        NameOfOperation = nameOfOperation;
        Information = info;
    }

    public string NameOfOperation { get; set; }

    public bool IsRed { get; set; }

    public Info Information { get; set; }

    public OperationStatus DeepCopy()
    {
        throw new NotImplementedException();
    }
}

public class Info : IDeepCopyable<OperationStatus>
{
    public Info(string messaage,string stack, int time)
    {
        Message = messaage;
        Stack = stack;
        Time = time;
    }

    public string Message { get; set; }

    public string Stack { get; set; }

    public int Time { get; set; }

    public OperationStatus DeepCopy()
    {
        throw new NotImplementedException();
    }
}
