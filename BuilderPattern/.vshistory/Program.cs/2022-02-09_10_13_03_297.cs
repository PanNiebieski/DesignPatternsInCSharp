
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

//var code = "Console.WriteLine(\"\");";
//var sb = new StringBuilder();
//sb.Append("<p><pre><code class=\"hljs cs\">");
//sb.Append(code);
//sb.Append("</code></pre></p><p>...</p>");
//Console.WriteLine(sb);


GetProcesses().Save(@"D:\proces.xml");

static XDocument GetProcesses()
{
    return new XDocument(
        new XElement("Processes",
            from p in Process.GetProcesses()
            orderby p.ProcessName ascending
            select new XElement("Process",
                new XAttribute("Name", p.ProcessName),
                new XAttribute("ProcessID", p.Id))));
}


