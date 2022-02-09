public class House : IDeepCopyable<House>
{ 
    public House DeepCopy()
    {
        var copy = new House();
        copy.Name = (String)Name.Clone();
        copy.Address = Address.DeepCopy();
        return copy;
    }

    public string Name { get; set; }
    public Address Address { get; set; }
    public House(string name, Address address) 
    {
        Name = name;
        Address = address;
    }

    public House()
    {
    }
}
