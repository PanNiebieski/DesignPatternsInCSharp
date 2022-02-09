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

    public List<HtmlElement> Elements { get; set; }

    public string Name { get; set; }

    public string Text { get; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"<{Name}>");

        foreach (var item in Elements)
        {
            sb.AppendLine(Text);
            sb.AppendLine(Text);
        }

        sb.AppendLine($"</{Name}>");
    }
}