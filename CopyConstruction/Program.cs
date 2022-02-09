using System.Runtime.Serialization.Formatters.Binary;

var annaHouse = new House(
"Anna House",
new Address("Lemonowa 12", 365));

var copy = annaHouse.DeepCopy<House>();


var anonim = new { test = "test", test2 = 1 };

var copy2 = anonim.DeepCopy();

public static class Tools
{
    public static T DeepCopy<T>(this T self)
    {
        using (var stream = new MemoryStream())
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            object copy = formatter.Deserialize(stream);
            return (T)copy;
        }
    }
} 


