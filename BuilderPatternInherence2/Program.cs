

var me = Shopping2.New
.When("Today")
.What("Game")
.Build();


public class Shopping2
{
    public string When;
    public string What;

    public class Builder : ShoppingWhatBuilder<Builder>
    {
        internal Builder() { }
    }

    public static Builder New => new Builder();
}



public abstract class ShoppingBuilder
{
    protected Shopping2 shopping = new Shopping2();
    public Shopping2 Build()
    {
        return shopping;
    }
}



public class ShoppingTimeBuilder<SELF> : ShoppingBuilder
where SELF : ShoppingTimeBuilder<SELF>
{
    public SELF When(string when)
    {
        shopping.When = when;
        return (SELF)this;
    }
}

public class ShoppingWhatBuilder<SELF>
: ShoppingTimeBuilder<ShoppingWhatBuilder<SELF>>
where SELF : ShoppingWhatBuilder<SELF>
{
    public SELF What(string what)
    {
        shopping.What = what;
        return (SELF)this;
    }
}