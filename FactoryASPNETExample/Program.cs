var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Func<Type, ISolider>>
   (
      provider => 
      { 
          return new Func<Type, ISolider>(
              (type) => 
              {
                  if (type == Type.Samurai)
                      return CreateSamurai();
                  return CreateNinja();
              }    
          ); 
      }
   );

var app = builder.Build();

int number = 0;

app.MapGet("/", (Func<Type, ISolider> func) =>
{
    var sol = func(Type.Samurai);
    number++;

    return $"Solider nr : {number} " +
    $"\n\t Kosztuje : {sol.Price()}" +
    $"\n\t Walczy : {sol.Fight()}";

});

app.MapGet("/n", (Func<Type, ISolider> func) =>
{
    var sol = func(Type.Ninja);
    number++;

    return $"Solider nr : {number} " +
    $"\n\t Kosztuje : {sol.Price()}" +
    $"\n\t Walczy : {sol.Fight()}";

});

app.Run();


Samurai CreateSamurai()
{
    return new Samurai();
}

Ninja CreateNinja()
{
    return new Ninja();
}

enum Type
{
    Samurai,
    Ninja
}