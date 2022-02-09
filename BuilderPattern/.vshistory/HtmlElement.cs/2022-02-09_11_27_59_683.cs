internal class HtmlElement
{
    public HtmlElement(string childName, string childText)
    {
        ChildName = childName;
        ChildText = childText;
    }

    public string Name { get; internal set; }
    public string ChildName { get; }
    public string ChildText { get; }
}