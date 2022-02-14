


//Do we need prototype object

PrototypeG prop = new("Andy", 2865, "Red");

var prop2 = prop with { serialnumber = 1203 };
var prop3 = prop with { serialnumber = 1855 };


var a1 = new Exam() 
{   B = 10, 
    C = new Inner() 
    { 
        D = 11 
    } 
};

var a2 = new Exam()
{
    B = a1.B,
    C = new Inner()
    {
        D = a1.C.D
    }
};

a1.C.D = 999;
var check = a1.C == a2.C;

Console.WriteLine();

public class Exam
{
    public int B { get; set; }
    public Inner C { get; set; }
}

public class Inner
{
    public int D { get; set; }
}


record PrototypeG(string name, int serialnumber, string color);