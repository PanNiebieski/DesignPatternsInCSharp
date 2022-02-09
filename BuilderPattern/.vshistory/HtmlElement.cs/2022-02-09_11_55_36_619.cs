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

    protected const int indentSize = 2;

    public int CurrentIndent { get; set; }

    public StringBuilder Build(StringBuilder sb,HtmlElement htmlElement)
    {
        //sb.Append(new String(' ', CurrentIndent));

        sb.AppendLine($"<{htmlElement.Name}>");

        if (!string.IsNullOrWhiteSpace(htmlElement.Text))
            sb.AppendLine(htmlElement.Text);

        foreach (var item in htmlElement.Elements)
        {
            //item.CurrentIndent = htmlElement.CurrentIndent + indentSize;
            Build(sb, item);
        }

        //sb.Append(new String(' ', CurrentIndent));
        sb.AppendLine($"</{Name}>");

        return sb;
    }

}