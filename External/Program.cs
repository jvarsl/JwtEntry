var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", (HttpContext ctx) => "Hello world!");

app.Run();
