
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

//var code = "Console.WriteLine(\"\");";
//var sb = new StringBuilder();
//sb.Append("<p><pre><code class=\"hljs cs\">");
//sb.Append(code);
//sb.Append("</code></pre></p><p>...</p>");
//Console.WriteLine(sb);


//GetProcesses().Save(@"D:\proces1.xml");

//static XDocument GetProcesses()
//{
//    return new XDocument(
//        new XElement("Processes",
//            Process.GetProcesses().OrderBy(p => p.ProcessName)
//            .Select(p => 
//                new XElement("Process",
//                new XAttribute("Name", p.ProcessName),
//                       new XAttribute("ProcessID", p.Id)))));
//}

var builder = new HtmlBuilder("ul");
builder.AddChild("li", "Twitter");
builder.AddChild("li", "Discord");
Console.WriteLine(builder.ToString());

class HtmlBuilder
{
    protected HtmlElement root;

    public HtmlBuilder(string rootName)
    {
        root= new HtmlElement(rootName);
    }

    public HtmlBuilder AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        root.Elements.Add(e);
        return this;
    }

    public override string ToString() => root.ToString();
}
