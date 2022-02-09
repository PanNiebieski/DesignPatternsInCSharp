var annaHouse = new House(
"Anna House",
new Address("Lemonowa 12", 365));

var annaHouseClone = annaHouse.DeepCopy();

bool check = annaHouseClone.Name == "Anna House";
bool check2 = annaHouseClone.Address.HouseNumber == 365;

Console.WriteLine("Before the change");
Console.WriteLine("Clone House");
Console.WriteLine(check);
Console.WriteLine("Clone Address");
Console.WriteLine(check2);

annaHouse.Name = "Test";
annaHouse.Address.HouseNumber = 0;
annaHouse.Address.StreetName = "streettest";

bool check3 = annaHouseClone.Name == "Anna House"; //will be ok

bool check4 = annaHouseClone.Address.HouseNumber == 365; //it will be ok beacuse of DeepCopy

Console.WriteLine("After change");
Console.WriteLine("Clone House");
Console.WriteLine(check3);
Console.WriteLine("Clone Address");
Console.WriteLine(check4);
