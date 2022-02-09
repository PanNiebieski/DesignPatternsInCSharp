


//Do we need prototype object

PrototypeG prop = new("Andy", 2865, "Red");

var prop2 = prop with { serialnumber = 1203 };
var prop3 = prop with { serialnumber = 1855 };

record PrototypeG(string name, int serialnumber, string color);
