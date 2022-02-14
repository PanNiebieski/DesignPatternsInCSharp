// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;
using System.Text;

var drawing = new GraphicObject { Name = "My Drawing" };
drawing.Children.Add(new Square { Color = "Green" });
drawing.Children.Add(new Circle { Color = "Purple" });

var group = new GraphicObject();
group.Children.Add(new Circle { Color = "Yellow" });
group.Children.Add(new Square { Color = "Yellow" });
drawing.Children.Add(group);
Console.WriteLine(drawing);

var neuron1 = new Neuron();
var neuron2 = new Neuron();
var layer1 = new NeuronLayer(3);
var layer2 = new NeuronLayer(4);
neuron1.ConnectTo(neuron2); // works already :)
neuron1.ConnectTo(layer1);
layer2.ConnectTo(neuron1);
layer1.ConnectTo(layer2);


public class Contract
{
    public int Id { get; set; }
    public string Content  { get; set; }

    public List<Contract> PreviousVersions { get; set; }
}

public class Battery
{
    public int SerialNumber { get; set; }

    public List<Cell> Cells { get; set; }

    public Battery()
    {
        Cells = new List<Cell>();
        for (int i = 0; i < 100; i++)
        {
            Cells.Add(new Cell());
        }
    }
}

public class Cell
{}


public class Glass
{
    public List<EventsOnGlass> Events { get; set; }

    public string Name { get; set; }
}

public abstract class EventsOnGlass
{

}







public class UlHtmlElement
{
    public virtual string Name { get; set; } = "ul";
    public string CssClass;

    private Lazy<List<UlHtmlElement>> children =
    new Lazy<List<UlHtmlElement>>();

    public List<UlHtmlElement> Children => children.Value;
}

public class LiHtmlElement : UlHtmlElement
{
    public override string Name => "li";
}
public class OlHtmlElement : UlHtmlElement
{
    public override string Name => "ol";
}


public class GraphicObject
{
    private void Print(StringBuilder sb, int depth)
    {
        sb.Append(new string('+', depth))
        .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty :
        $"{Color} ")
        .AppendLine($"{Name}");
        foreach (var child in Children)
            child.Print(sb, depth + 1);
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        Print(sb, 0);
        return sb.ToString();
    }

    public virtual string Name { get; set; } = "Group";
    public string Color;

    private Lazy<List<GraphicObject>> children =
    new Lazy<List<GraphicObject>>();

    public List<GraphicObject> Children => children.Value;
}

public class Circle : GraphicObject
{
    public override string Name => "Circle";
}
public class Square : GraphicObject
{
    public override string Name => "Square";
}


public class Neuron
{
    public List<Neuron> In { get; set; }
    public List<Neuron> Out { get; set; }

    public void ConnectTo(Neuron other)
    {
        Out.Add(other);
        other.In.Add(this);
    }

    public Neuron()
    {
        In = new List<Neuron>();
        Out = new List<Neuron>();
    }
}


public class NeuronLayer : Collection<Neuron>
{
    public NeuronLayer(int count)
    {
        while (count-- > 0)
            Add(new Neuron());
    }

    public void ConnectTo(NeuronLayer other)
    {
        Out.Add(other);
        other.In.Add(this);
    }

    public List<NeuronLayer> In { get; set; }
    public List<NeuronLayer> Out { get; set; }

}
