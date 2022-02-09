
using System.Dynamic;

var stats = new GameStats(null);
stats.AddCoins(5);




public class Null<T> : DynamicObject where T : class
{
    public override bool TryInvokeMember(InvokeMemberBinder
    binder, object[] args, out object result)
    {
        var name = binder.Name;
        result = Activator.CreateInstance(binder.ReturnType);
        return true;
    }
}