using System.Text;

public  class HtmlElement
{
    public HtmlElement(string name)
    {
        Name = name;
    }

    public HtmlElement(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public List<HtmlElement> Elements { get; set; } = new List<HtmlElement>();

    public string Name { get; set; }

    public string Text { get; }

    public override string ToString()
    {

        StringBuilder sb = new StringBuilder();


        Build(sb,this);

        return sb.ToString();
    }

    public StringBuilder Build(StringBuilder sb,HtmlElement htmlElement)
    {
        sb.AppendLine($"<{htmlElement.Name}>");

        foreach (var item in htmlElement.Elements)
        {
            sb.AppendLine(htmlElement.Text);
            Build(sb, item);
        }

        sb.AppendLine($"</{Name}>");

        return sb;
    }

}