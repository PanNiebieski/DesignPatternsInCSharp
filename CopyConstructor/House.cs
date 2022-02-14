public class House 
{
    public House(House other)
    {
        Name = (String)other.Name.Clone();
        Address = new Address(other.Address);
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
