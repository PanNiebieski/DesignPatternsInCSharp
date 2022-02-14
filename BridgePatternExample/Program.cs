

var rectangleStamp = new ConsoleRectangleYellowStampMaker();
var squareStamp = new ConsoleSquareBlueStampMaker();

var squareG = new Graphics(squareStamp, 6);
squareG.Draw();
Console.WriteLine("\n");
squareG.Magnifying(4);
squareG.Draw();
Console.WriteLine("\n");
squareG.Reducing(2);
squareG.Draw();
Console.WriteLine("\n");

var rectangleG = new Graphics(rectangleStamp, 4);
rectangleG.Draw();
Console.WriteLine("\n");
rectangleG.Magnifying(4);
rectangleG.Draw();
Console.WriteLine("\n");
rectangleG.Reducing(2);
rectangleG.Draw();
Console.WriteLine("\n");



public interface IStampMaker
{
    void Render(int size);
}


public abstract class GraphicsBridge
{
    protected IStampMaker stamper;
    // most pomiędzy grafiką która będzie rysowana 
    // a komponentem który rzeczywiście go rysuje
    // a bridge between the graphics that's being drawn and
    // the component stampMaker that actually draws it

    public GraphicsBridge(IStampMaker stamper)
    {
        this.stamper = stamper;
    }

    public abstract void Draw();
    public abstract void Magnifying(int factor);
    public abstract void Reducing(int factor);
}


public class Graphics : GraphicsBridge
{
    private int size;
    public Graphics(IStampMaker stamper, int size) : base(stamper)
    {
        this.size = size;
    }
    public override void Draw()
    {
        stamper.Render(size);
    }
    public override void Magnifying(int factor)
    {
        size *= factor;
    }

    public override void Reducing(int factor)
    {
        if (factor != 0)
            size /= factor;
    }
}

//public class SquareGraphics : GraphicsBridge
//{
//    private int size;
//    public SquareGraphics(IStampMaker stamper, int size) : base(stamper)
//    {
//        this.size = size;
//    }
//    public override void Draw()
//    {
//        stamper.(size);
//    }
//    public override void Magnifying(int factor)
//    {
//        size *= factor;
//    }

//    public override void Reducing(int factor)
//    {
//        if (factor != 0)
//            size /= factor;
//    }
//}

public class ConsoleRectangleYellowStampMaker : IStampMaker
{
    public void Render(int size)
    {
        int s = Math.Abs(size) + 2;

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine(new string('#', s));
        Console.Write('#');
        Console.Write(new string('+', s - 2));
        Console.Write("#\n");

        Console.WriteLine(new string('#', s));
        Console.ResetColor();
    }
}


public class ConsoleSquareBlueStampMaker : IStampMaker
{
    public void Render(int size)
    {
        int s = Math.Abs(size) + 2;
        int p = size * 2;

        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine(new string('#', p));

        for (int i = 0; i < (s - 2); i++)
        {
            Console.Write('#');
            Console.Write(new string('+', p - 2));
            Console.Write("#\n");
        }

        Console.WriteLine(new string('#', p));
        Console.ResetColor();
    }
}