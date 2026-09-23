var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

var app = builder.Build();

app.UseCors(policy => policy.AllowAnyOrigin());

app.MapGet("/", () => new[]
{
    new { id = "1", title = "Book Review: The Name of the Wind" },
    new { id = "2", title = "Game Review: Pokemon Brillian Diamond" },
    new { id = "3", title = "Show Review: Alice in Borderland" }
});

app.Run();
