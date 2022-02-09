var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<CachedData>();
builder.Services.AddSingleton<ICourseService, CourseService>();
builder.Services.AddSingleton<IImageSaveService, ImageSaveService>();
builder.Services.AddSingleton<ISaveDeletePostService, SaveDeletePostService>();

var app = builder.Build();

app.MapGet("/",  (CachedData cachedData) => "Hello CachedData !");
app.MapGet("/a", (ICourseService cachedData) => "ICourseService");
app.MapGet("/b", (IImageSaveService cachedData) => "IImageSaveService");
app.MapGet("/c", (ISaveDeletePostService cachedData) => "ISaveDeletePostService");

app.Run();


public interface ICourseService
{

}

public interface IImageSaveService
{

}

public interface ISaveDeletePostService
{

}

public class SaveDeletePostService : ISaveDeletePostService
{
    public SaveDeletePostService()
    {
        Console.WriteLine("Initializing SaveDeletePostService");
    }
}

public class ImageSaveService : IImageSaveService
{
    public ImageSaveService()
    {
        Console.WriteLine("Initializing ImageSaveService");
    }
}

public class CourseService : ICourseService
{
    public CourseService()
    {
        Console.WriteLine("Initializing CourseService");
    }
}

public class CachedData
{
    public CachedData()
    {
        Console.WriteLine("Initializing CachedData");
    }


}