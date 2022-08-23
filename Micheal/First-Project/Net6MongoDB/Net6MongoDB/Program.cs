using MongoDB.Driver;
using MongoDB.Entities;
using Net6MongoDB.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IuserRepo, UserRepo>();  
await DB.InitAsync("UserManagement",
    MongoClientSettings.FromConnectionString(
        "mongodb+srv://Micheal:onimisi55@net6withmongodb.xuv68lp.mongodb.net/?retryWrites=true&w=majority"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
