var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/example", () =>
{
    var response = new { Message = "Привет, Максим!" };
    return Results.Json(response);
});

app.Run();
