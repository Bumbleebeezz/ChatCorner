using ChatCorner.API.Dataccess;
using ChatCorner.API.Dataccess.Entities;
using ChatCorner.DataTransferContract.ChatContracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDataAccess();

var app = builder.Build();

app.MapGet("/", () => "API is running!");

// Strategy pattern
app.MapPost("/messages", async (IChatMessageRepository repo, ChatMessage message) =>
{
    await repo.AddOneAsync(message);
});
app.MapGet("/messages", async (IChatMessageRepository repo, int start, int count) =>
{
    return await repo.GetManyAsync(start,count);
});

app.Run();
