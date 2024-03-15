using AllDo.Domain;
using AllDo.Infrastructure.Data;
using AllDo.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AllDoDbContext>();
builder.Services.AddScoped<IRepository<Bug>, BugRepository>();
builder.Services.AddScoped<IRepository<Feature>, FeatureRepository>();
builder.Services.AddScoped<IRepository<TodoTask>, TodoTaskRepository>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

 AllDoDbContext.EnsureCreated();

// app.MapGet("/todos", async (IRepository<TodoTask> repo) => await repo.AllAsync()).Produces<TodoTask[]>(StatusCodes.Status200OK);


app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
