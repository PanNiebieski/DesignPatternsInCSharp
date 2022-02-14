var builder = new HtmlBuilder("ul");
builder.AddChild("li", "Twitter");
builder.AddChild("li", "Discord");
Console.WriteLine(builder.ToString());

public class HtmlBuilder
{
    protected HtmlElement root;

    public HtmlBuilder(string rootName)
    {
        root = new HtmlElement(rootName);
    }

    public HtmlBuilder AddChild(string childName,
        string childText)
    {
        var e = new HtmlElement(childName, childText);
        root.Elements.Add(e);
        return this;
    }

    public override string ToString() => root.ToString();
}

