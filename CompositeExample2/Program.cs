// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

Neuron a =  new Neuron();
Neuron b = new Neuron();
a.ConnectTo(b);

List<Neuron> layer = new List<Neuron>();
Neuron c = new Neuron();
Neuron d = new Neuron();
layer.Add(c);
layer.Add(d);

b.ConnectTo(layer);

public class Neuron : IEnumerable<Neuron>
{
    public List<Neuron> In { get; set; }
    public List<Neuron> Out { get; set; }

    public IEnumerator<Neuron> GetEnumerator()
    {
        yield return this;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public static class ExtensionMethods
{
    public static void ConnectTo(
    this IEnumerable<Neuron> self, IEnumerable<Neuron> other)
    {
        if (ReferenceEquals(self, other)) return;
        foreach (var from in self)
            foreach (var to in other)
            {
                from.Out.Add(to);
                to.In.Add(from);
            }
    }
}