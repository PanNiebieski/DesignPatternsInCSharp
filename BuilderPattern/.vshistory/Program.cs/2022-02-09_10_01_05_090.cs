
using System.Text;

var code = "Console.WriteLine(\"\");";
var sb = new StringBuilder();
sb.Append("<p><pre><code class=\"hljs cs\">");
sb.Append(code);
sb.Append("</code></pre></p><p>...</p>");
Console.WriteLine(sb);


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
