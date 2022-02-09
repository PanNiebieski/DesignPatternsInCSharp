

var me = Shopping2.New
.When("Today")
.What("Game")
.Build();

public class Shopping
{
    public string When;
    public string What;
}

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
    protected Shopping shopping = new Shopping();
    public Shopping Build()
    {
        return shopping;
    }
}

public class ShoppingTimeBuilder : ShoppingBuilder
{
    public ShoppingTimeBuilder When(string when)
    {
        shopping.When = when;
        return this;
    }
}

public class ShoppingWhatBuilder : ShoppingTimeBuilder
{
    public ShoppingWhatBuilder What(string what)
    {
        shopping.What = what;
        return this;
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