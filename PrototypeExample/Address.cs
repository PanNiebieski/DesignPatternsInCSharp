public class Address : IDeepCopyable<Address>
{
    public Address DeepCopy()
    {
        return new Address(StreetName, HouseNumber);
    }

    public string StreetName { get; set; }
    public int HouseNumber { get; set; }
    public Address(string streetName, int houseNumber) 
    {
        StreetName = streetName;
        HouseNumber = houseNumber;
    }
}