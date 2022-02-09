using System.Text;

public  class HtmlElement
{
    public HtmlElement()
    {
    }

    public HtmlElement(string childName, string childText)
    {
        ChildName = childName;
        ChildText = childText;
    }

    public List<HtmlElement> Elements { get; set; }

    public string Name { get; internal set; }
    public string ChildName { get; }
    public string ChildText { get; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"<{Name}>");

        foreach (var item in Elements)
        {

        }

        sb.AppendLine($"</{Name}>");
    }
}