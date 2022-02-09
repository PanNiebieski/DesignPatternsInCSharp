public class House 
{
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
