using System.Security.Cryptography;

var rsaKey = RSA.Create();
rsaKey.ImportRSAPrivateKey(File.ReadAllBytes("D:\\Dev\\Dotnet\\Jwt\\KeyGen\\key"), out _);


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", (HttpContext ctx) => "Hello world!");

app.Run();