

using System.Xml;
using System.Xml.Serialization;


XmlSerializer xsSubmit = new XmlSerializer(typeof(World));
var subReq = new World();
var xml = "";

using (var sww = new StringWriter())
{
    using (XmlWriter writer = XmlWriter.Create(sww))
    {
        xsSubmit.Serialize(writer, subReq);
        xml = sww.ToString(); 
    }
}

Console.WriteLine(xml);

public class World
{
 
    public Dictionary<string,string> Capitals { get; set; }

    public (string, string)[] CapitalsSerializable
    {
        get
        {
            return Capitals.Keys.Select(country =>
            (country, Capitals[country])).ToArray();
        }
        set
        {
            Capitals = value.ToDictionary(x => x.Item1, x => x.Item2);
        }
    }

    public World()
    {
        Capitals = new Dictionary<string, string>()
        {
            {"Afghanistan","Kabul" },
            {"Brazil","Brasilia" },
            {"Bulgaria","Sofia" },
            {"Bolivia","Sucre" },
            {"Cyprus","Nicosia" },
            {"Denmark","Copenhagen" },
            {"England","London" },
            {"Finland","Kabul" },
            {"France","Paris" },
            {"Poland","Warsaw" },
        };
    }
}
