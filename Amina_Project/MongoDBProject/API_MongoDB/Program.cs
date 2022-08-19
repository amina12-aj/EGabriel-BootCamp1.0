using API_MongoDB.Respository;
using MongoDB.Driver;
using MongoDB.Entities;

var builder = WebApplication.CreateBuilder(args);

await DB.InitAsync("UserManagement",
    MongoClientSettings.FromConnectionString(
        "mongodb//Amina_projects:nikesisteR1@apicluster.3bmdiwh.mongodb.net/?retryWrites=true&w=majority"));
// Add services to the container.

builder.Services.AddScoped<IUserRepo, UserRepo>();
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
