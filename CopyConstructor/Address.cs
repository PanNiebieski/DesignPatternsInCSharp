public class Address 
{
    public Address(Address other)
    {
        StreetName = other.StreetName;
        HouseNumber = other.HouseNumber;
    }

    public string StreetName { get; set; }
    public int HouseNumber { get; set; }
    public Address(string streetName, int houseNumber) 
    {
        StreetName = streetName;
        HouseNumber = houseNumber;
    }
}