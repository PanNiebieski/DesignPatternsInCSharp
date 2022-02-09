using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

var code = "Console.WriteLine(\"\");";
var sb = new StringBuilder();
sb.Append("<p><pre><code class=\"hljs cs\">");
sb.Append(code);
sb.Append("</code></pre></p><p>...</p>");
Console.WriteLine(sb);


GetProcesses().Save(@"D:\proces1.xml");

static XDocument GetProcesses()
{
    return new XDocument(
        new XElement("Processes",
            Process.GetProcesses().OrderBy(p => p.ProcessName)
            .Select(p =>
                new XElement("Process",
                new XAttribute("Name", p.ProcessName),
                       new XAttribute("ProcessID", p.Id)))));
}


