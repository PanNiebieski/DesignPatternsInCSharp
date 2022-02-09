
var annaHouse = new House(
"Anna House",
new Address("Lemonowa 12", 365));

var clone1 = annaHouse.With();
var clone2 = annaHouse.With("New Name");

var clone3 = annaHouse.With(
    new Address("test",11));


public static class Extensions
{
    public static House With(this House house)
    {
        var copy = new House();
        copy.Name = (String)house.Name.Clone();
        copy.Address = house.Address.With();
        return copy;
    }

    public static House With(this House house, string name)
    {
        var copy = new House();
        copy.Name = name;
        copy.Address = house.Address.With();
        return copy;
    }

    public static House With(this House house, Address adress)
    {
        var copy = new House();
        copy.Name = (String)house.Name.Clone();
        copy.Address = adress;
        return copy;
    }


    public static Address With(this Address adress)
    {
        return new Address(adress.StreetName, adress.HouseNumber);
    }
    public static Address With(this Address adress,string streetName)
    {
        return new Address(streetName, adress.HouseNumber);
    }

    public static Address With(this Address adress, int houseNumber)
    {
        return new Address(adress.StreetName, houseNumber);
    }

}
