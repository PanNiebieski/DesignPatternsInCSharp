var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IStampMaker, ConsoleSquareBlueStampMaker>();
builder.Services.AddSingleton<GraphicsBridge, Graphics>
    (
    (provider) => 
        { 
            var stamp = provider.GetService<IStampMaker>();
            return new Graphics(stamp, 10);
        }
    );

var app = builder.Build();

app.MapGet("/", (GraphicsBridge graphics) => graphics.Draw());

app.MapGet("/m/{number:int}", 
    (GraphicsBridge graphics, int number) => graphics.Magnifying(number));

app.MapGet("/r/{number:int}", 
    (GraphicsBridge graphics, int number) => graphics.Reducing(number));
app.Run();








public interface IStampMaker
{
    void Render(int size);
}


public abstract class GraphicsBridge
{
    protected IStampMaker stamper;
    // most pomi?dzy grafik? która b?dzie rysowana 
    // a komponentem który rzeczywi?cie go rysuje
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
