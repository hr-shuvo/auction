using SearchService.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

try
{
    await builder.Services.Initialize(builder.Configuration);
}
catch (Exception e)
{
    Console.WriteLine(e);
}

var app = builder.Build();


app.MapControllers();



app.Run();